using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TomiSoft.RolandStyleReader;

namespace TomiSoft_Style_Studio {
	public class ChordTypeEventArgs : EventArgs {
		private ChordType chordType;

		public ChordType ChordType {
			get { return chordType; }
		}

		public ChordTypeEventArgs(ChordType ctype) {
			this.chordType = ctype;
		}
	}
}
