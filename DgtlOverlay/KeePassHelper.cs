using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeePassLib;
using KeePassLib.Collections;

namespace DgtlOverlay
{
	class KeePassHelper
	{
		public static PwObjectList<PwEntry> PerformSearch(PwDatabase database, String sValue)
		{
			// Build search params
			SearchParameters sp = new SearchParameters();
			sp.SearchString = sValue;

			// Build result group
			PwGroup pg = new PwGroup(true, true);
			pg.IsVirtual = true;
			PwObjectList<PwEntry> listResults = pg.Entries;

			// Make sure the database is open
			if (database.IsOpen)
			{
				// Execute search
				Exception exFind = null;
				try { database.RootGroup.SearchEntries(sp, listResults); }
				catch (Exception ex) { exFind = ex; }
			}

			// Return the list of results (Will be empty if database isn't open)
			return listResults;
		}
	}
}
