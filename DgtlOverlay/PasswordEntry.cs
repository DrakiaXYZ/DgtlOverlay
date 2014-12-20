using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeePassLib;

namespace DgtlOverlay
{
	class PasswordEntry
	{
		private string Description;
		private PwEntry Entry;

		public PasswordEntry(string description, PwEntry pe)
		{
			this.Description = description;
			this.Entry = pe;
		}

		public override string ToString()
		{
			return Description;
		}

		public PwEntry GetEntry()
		{
			return Entry;
		}
	}
}
