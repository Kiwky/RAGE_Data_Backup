using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Data {

	// Server class. 
	class Data_Ban {

		// STRING
		public string reason { get; set; }
		public string adminName { get; set; }

		// INTEGER
		public int id { get; set; }
		public int time { get; set; }
		public int expire { get; set; }

		// BOOL
		public bool isBanned { get; set; }
	}
}
