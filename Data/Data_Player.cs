using System;

namespace RMC.Data {

	#region ENUMS
	[Flags]
	public enum Permissions : int {
		kick     /**/ = 1 << 0,
		ban      /**/ = 1 << 1,
		spawn    /**/ = 1 << 2,
		teleport /**/ = 1 << 3
	}
	#endregion

	// Server class. 
	public class Data_Player {

		public int id { get; set; }
		public int money { get; set; }
		public int bank { get; set; }
		public int premium_points { get; set; }
		public Permissions adminPermission { get; set; }
		public string adminName { get; set; }

		public string username { get; set; }
		public string password { get; set; }

	}

}