using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Data {

	// Server class. 
	class Data_Constants {

		#region SERVER
		public const string SERVER_VERSION = "0.0.1B";
		#endregion

		#region JOB_CONSTANTS
		public enum JOB_ID : int {
			NONE = 0,
			TRUCKER = 1,
		}

		public static List<Data_Job> Job_List = new List<Data_Job>() {
			new Data_Job("Unemployed", (int)JOB_ID.NONE, 0),
			new Data_Job("Trucker", (int)JOB_ID.TRUCKER, 0),
		};

		public static Vector3 TRUCKER_POS = new Vector3(733.18f, -1270.01f, 26.0f);
		public static Vector3 TRUCKER_POS_GOTO = new Vector3(728.18f, -1264.01f, 26.0f);
		#endregion

		#region TIME_CONSTANTS
		public const string TIME_SECONDS = "secunde";
		public const string TIME_MINUTES = "minute";
		public const string TIME_HOURS = "ore";
		public const string TIME_DAYS = "zile";
		#endregion

		#region COLOR_CONSTANTS
		public const string COLOR_ADMIN_INFO = "!{#FF2D00}";
		#endregion

	}

}
