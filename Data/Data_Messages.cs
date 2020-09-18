using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Data {

	// Server class. 
	class Data_Messages {

		// =======================================================================================================
		public const string TARGET_NOT_EXIST = "Jucatorul nu exista.";

		// =======================================================================================================
		public const string NO_PERMISSION = "Nu ai acces.";

		// ======================= Admin Commands =======================
		public const string CMD_KICK = "kick";
		public const string CMD_KICK_DESC = "Foloseste : /kick [nume] [motiv]";
		public const string PLAYER_KICKED = "{1} a primit kick de la {0}. Motiv: {2}";

		public const string CMD_BAN = "ban";
		public const string CMD_BAN_DESC = "Foloseste : /ban [nume] [timp (minute)] [motiv]";
		public const string PLAYER_BANED = "{1} a fost banat de {0} [Timp: {2}]. Motiv: {3}";

		public const string CMD_SPAWNCAR = "car";
		public const string CMD_SPAWNCAR_DESC = "Foloseste : /car [masina]";
		public const string CAR_SPAWNED = "Masina a fost spawnata";
		public const string CAR_NOT_FOUND = "Masina nu a fosta gasita.";

		public const string CMD_TELEPORT = "teleport";
		public const string CMD_TELEPORT_DESC = "Foloseste : /teleport [pos1] [pos2] [pos3]";
		public const string PLAYER_TELEPORTED = "Ai fost teleportat.";

		public const string CMD_GOTO = "goto";
		public const string CMD_GOTO_DESC = "Foloseste : /goto [name]";
		public const string PLAYER_GOTOED = "Ai fost teleportat.";
		// ======================= Admin Commands =======================

		// ======================= Login & Register =======================
		public const string YOU_ARE_BANNED = "Contul este banat pentru {0} {1}";
		public const string YOU_ARE_PERMA_BANNED = "Contul este banat PERMANENT";
		public const string SUCCESSFULLY_LOGIN = "Te-ai conectat cu succes";
		public const string SUCCESSFULLY_CREATED = "Contul a fost creat cu succes";
		public const string ACCOUNT_NOT_EXIST = "Contul nu exista";
		public const string USERNAME_USED = "Numele de utilizator este folosit";
		// ======================= Login & Register =======================

	}

}
