using System.Collections.Generic;

namespace RMC.Data {

	// Server class. 
	// Client class.
	public class Data_JobMenu {

		public int job_id { get; set; }
		public string job_name { get; set; }
		public string job_description { get; set; }
		public string description { get; set; }
		public List<string> info { get; set; }
		public List<string> req { get; set; }
		public string img { get; set; }

	}
}
