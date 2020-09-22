namespace RMC.Data {

	// Server class. 
	public class Data_Job {

		public int jobId { get; set; }
		public int salary { get; set; }

		public string name { get; set; }

		public Data_Job(string _name, int _jobId, int _salary) {
			name = _name;
			jobId = _jobId;
			salary = _salary;
		}
	}

}
