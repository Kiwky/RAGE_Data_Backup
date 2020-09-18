using Newtonsoft.Json;
using RMC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.CFG {

	// Server class. 
	public class Data_Cfg {

		public int Start_Money { get; set; } = 0;
		public int Start_Bank { get; set; } = 0;
		public int Start_Admin { get; set; } = 0;
		public int Start_Premium_Points { get; set; } = 0;

		public Dictionary<string, string> Permissions =
			new Dictionary<string, string>();
	}

}
