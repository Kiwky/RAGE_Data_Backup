using GTANetworkAPI;

namespace RMC.Data {

	// Server class. 
	public class Data_Vehicle {

		public int id { get; set; }
		public int colorType { get; set; }
		public int locked { get; set; }
		public int engine { get; set; }
		public int price { get; set; }

		public float gas { get; set; }
		public float kms { get; set; }

		public string model { get; set; }
		public string owner { get; set; }
		public string plate { get; set; }
		public string firstColor { get; set; }
		public string secondColor { get; set; }

		public Vector3 position { get; set; }
		public Vector3 rotation { get; set; }

	}

}
