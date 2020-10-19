using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Data {

	// Server class. 
	public class Data_Constants {

		#region ENUMS
		[Flags]
		public enum Permissions : int {
			kick        /**/ = 1 << 0,
			ban         /**/ = 1 << 1,
			spawn       /**/ = 1 << 2,
			teleport    /**/ = 1 << 3,
			warn        /**/ = 1 << 4,
			givemoney   /**/ = 1 << 5,
			givepp      /**/ = 1 << 6,
			heal        /**/ = 1 << 7,
		}

		public enum Item_Type : int {
			ITEM_NONE,          // 0
			ITEM_FOOD,          // 1
			ITEM_NUMERABLE,		// 2
			ITEM_CAP,			// 3
			ITEM_GLASSES,		// 4
			ITEM_TSHIRT,		// 5
			ITEM_JACKET,		// 6
			ITEM_CLOCK,			// 7
			ITEM_PANTS,			// 8
			ITEM_SNEAKERS,		// 9
		}
		#endregion

		#region SERVER
		public const string SERVER_VERSION = "0.0.1B";

		public static Dictionary<string, Permissions> GlobalPermissions = new Dictionary<string, Permissions>();
		public static Dictionary<string, Data_ServerItem> GlobalItems = new Dictionary<string, Data_ServerItem>();
		#endregion

		#region JOB_CONSTANTS
		public enum JOB_ID : int {
			NONE = 0,
			TRUCKER,
			GARBAGE
		}

		public static List<Data_Job> Job_List = new List<Data_Job>() {
			new Data_Job("Unemployed", (int)JOB_ID.NONE, 0, Data_Messages.DESC_UNEMPLOYED),
			new Data_Job("Trucker", (int)JOB_ID.TRUCKER, 0, Data_Messages.DESC_TRUCKER),
			new Data_Job("Garbage", (int)JOB_ID.GARBAGE, 0, Data_Messages.DESC_GARBAGE),
		};

		public static Vector3 TRUCKER_POS = new Vector3(733.18f, -1270.01f, 26.0f);
		#endregion

		#region MARKERS
		public static List<Data_Marker> Marker_List = new List<Data_Marker>() {
			new Data_Marker("Trucker", new Vector3(728.18f, -1264.01f, 26.0f)),
		};
		#endregion

		#region VEHICLES
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
