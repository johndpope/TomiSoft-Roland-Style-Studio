using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using TomiSoft.RolandStyleReader;
using Midi;

namespace TomiSoft_Style_Studio {
	class MidiMessagePlayer {
		private OutputDevice Device;
		private int Tempo;
		private IEnumerable<StyleEntry> Messages;
		private MessageScheduler Scheduler;
		private volatile bool isPlaying;

		public bool IsPlaying {
			get {
				return this.isPlaying;
			}
		}

		public float Position {
			get {
				return Scheduler.Clock.Time;
			}
		}

		public int TotalTime {
			get {
				return Scheduler.Length;
			}
		}
		
		public MidiMessagePlayer(int Tempo, OutputDevice Device, IEnumerable<StyleEntry> Messages) {
			this.Device = Device;
			this.Tempo = Tempo;
			this.Messages = Messages;

			Scheduler = new MessageScheduler(Tempo, Device);
			Scheduler.ScheduleMessages(Messages, this.OnStop);
		}

		private void OnStop(float Time) {
			this.isPlaying = false;
		}

		public void Play() {
			Scheduler.Clock.Start();
			this.isPlaying = true;
		}

		public void Stop() {
			Scheduler.Clock.Stop();
			this.isPlaying = false;
		}

		public void Rewind() {
			Scheduler.Clock.Reset();
		}
	}
}
