using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TomiSoft.RolandStyleReader;

namespace TomiSoft_Style_Studio {
	public class InstrumentEventArgs : EventArgs {
		private Instrument instrument;

		public Instrument Instrument {
			get { return instrument; }
		}

		public InstrumentEventArgs(Instrument instr) {
			this.instrument = instr;
		}
	}
}
