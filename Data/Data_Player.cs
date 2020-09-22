using System;

namespace RMC.Data {

	// Server class. 
	public class Data_Player {

		public int id { get; set; }
		public int money { get; set; }
		public int bank { get; set; }
		public int premium_points { get; set; }
		//public Permissions adminPermission { get; set; }
		public string adminName { get; set; }

		public string username { get; set; }
		public string password { get; set; }

	}

}