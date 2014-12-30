using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TomiSoft.RolandStyleReader;
using Midi;

namespace TomiSoft_Style_Studio {
	class MessageScheduler {
		private Dictionary<TomiSoft.RolandStyleReader.Instrument, Channel> ChannelMappings = new Dictionary<TomiSoft.RolandStyleReader.Instrument, Channel>() {
			{TomiSoft.RolandStyleReader.Instrument.Drum, Channel.Channel10},
			{TomiSoft.RolandStyleReader.Instrument.Bass, Channel.Channel2},
			{TomiSoft.RolandStyleReader.Instrument.Acc1, Channel.Channel5},
			{TomiSoft.RolandStyleReader.Instrument.Acc2, Channel.Channel6},
			{TomiSoft.RolandStyleReader.Instrument.Acc3, Channel.Channel7},
			{TomiSoft.RolandStyleReader.Instrument.Acc4, Channel.Channel8},
			{TomiSoft.RolandStyleReader.Instrument.Acc5, Channel.Channel9},
			{TomiSoft.RolandStyleReader.Instrument.Acc6, Channel.Channel12}
		};

		private OutputDevice Device;
		private Clock clock;
		private int length = 0;

		public int Length {
			get {
				return this.length;
			}
		}
		
		public Clock Clock {
			get {
				return this.clock;
			}
		}

		public MessageScheduler(int Tempo, OutputDevice Device) : this(Tempo, Device, new Clock(Tempo)) { }

		public MessageScheduler(int Tempo, OutputDevice Device, Clock c) {
			this.Device = Device;
			this.clock = c;
		}

		public void ScheduleMessages(IEnumerable<StyleEntry> Messages) {
			foreach (var item in Messages) {
				this.clock.Schedule(this.ConvertMessage(item));

				if (this.length < item.Message.TotalTime) {
					this.length = item.Message.TotalTime;
					if (item.Message is TomiSoft.RolandStyleReader.NoteMessage) {
						this.length += ((TomiSoft.RolandStyleReader.NoteMessage)item.Message).Length;
					}
				}
			}
		}

		public void ScheduleMessages(IEnumerable<StyleEntry> Messages, CallbackMessage.CallbackType OnStop) {
			this.ScheduleMessages(Messages);

			CallbackMessage StopMessage = new CallbackMessage(OnStop, this.length + 4);
		}

		private Message ConvertMessage(StyleEntry msg) {
			switch (msg.Message.MessageType) {
				case MidiMessageType.Note:
					return this.GetNoteOnOffMessage(msg);

				case MidiMessageType.PitchWheel:
					return this.GetPitchBendMessage(msg);

				case MidiMessageType.ControlChange:
					return this.GetControlChangeMessage(msg);

				default:
					return null;
			}
		}

		private NoteOnOffMessage GetNoteOnOffMessage(StyleEntry msg) {
			TomiSoft.RolandStyleReader.NoteMessage m = (TomiSoft.RolandStyleReader.NoteMessage)msg.Message;

			return new NoteOnOffMessage(
				this.Device,
				ChannelMappings[msg.Instrument],
				(Pitch)((m.Note < 128) ? m.Note : 1),
				m.Velocity,
				m.TotalTime / 120f,
				this.clock,
				m.Length
			);
		}

		private PitchBendMessage GetPitchBendMessage(StyleEntry msg) {
			TomiSoft.RolandStyleReader.PitchWheelMessage m = (TomiSoft.RolandStyleReader.PitchWheelMessage)msg.Message;

			return new PitchBendMessage(
				this.Device,
				ChannelMappings[msg.Instrument],
				0,
				m.TotalTime
			);
		}

		private Midi.ControlChangeMessage GetControlChangeMessage(StyleEntry msg) {
			TomiSoft.RolandStyleReader.ControlChangeMessage m = (TomiSoft.RolandStyleReader.ControlChangeMessage)msg.Message;

			Dictionary<ControlType, Control> ControlMappings = new Dictionary<ControlType, Control>() {
				{ControlType.Chorus, Control.ChorusLevel},
				{ControlType.Expression, Control.Expression},
				{ControlType.Pan, Control.Pan},
				{ControlType.Reverb, Control.ReverbLevel}
			};

			return new Midi.ControlChangeMessage(
				this.Device,
				ChannelMappings[msg.Instrument],
				ControlMappings[m.Control],
				m.Value,
				m.TotalTime
			);
		}
	}
}
