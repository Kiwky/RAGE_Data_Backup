using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Data {

	// Server class. 
	public class Data_Marker {

		public string name { get; set; }
		public Vector3 position { get; set; }

		public Data_Marker(string _name, Vector3 _position) {
			name = _name;
			position = _position;
		}
	}

}
