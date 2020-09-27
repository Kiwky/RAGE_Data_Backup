namespace RMC.Data {

	// Server class. 
	class Data_Messages {

		// ======================= General =======================
		#region GENERAL
		public const string TARGET_NOT_EXIST = "Jucatorul nu exista.";
		#endregion
		// ======================= General =======================

		// ======================= Permissions =======================
		#region PERMISSIONS
		public const string NO_PERMISSION = "Nu ai acces.";
		#endregion
		// ======================= Permissions =======================

		// ======================= Admin Commands =======================
		#region ADMIN_COMMANDS
		public const string CMD_KICK = "kick";
		public const string CMD_KICK_DESC = "Foloseste : /kick [nume] [motiv]";
		public const string PLAYER_KICKED = "{1} a primit kick de la {0}. Motiv: {2}.";

		public const string CMD_BAN = "ban";
		public const string CMD_BAN_DESC = "Foloseste : /ban [nume] [timp (minute)] [motiv]";
		public const string PLAYER_BANED = "{1} a fost banat de {0} [Timp: {2}]. Motiv: {3}.";

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

		public const string CMD_WARN = "warn";
		public const string CMD_WARN_DESC = "Foloseste : /warn [nume] [motiv]";
		public const string PLAYER_WARNED = "{0} a primit warn de la {1}. Motiv: {2}.";

		// De facut comanda.
		public const string CMD_GIVEMONEY = "givemoney";
		public const string CMD_GIVEMONEY_DESC = "Foloseste : /givemoney [nume] [suma]";
		public const string MONEY_GIVED = "{0} ti-a dat {1} bani.";

		// De facut comanda.
		public const string CMD_GIVEPP = "givepp";
		public const string CMD_GIVEPP_DESC = "Foloseste : /givepp [nume] [suma]";
		public const string PP_GIVED = "{0} ti-a dat {1} puncte premium.";

		// De facut comanda.
		public const string CMD_TAKEMONEY = "takemoney";
		public const string CMD_TAKEMONEY_DESC = "Foloseste : /takemoney [nume] [suma]";
		public const string MONEY_TAKED = "{0} ti-a luat {1} bani.";

		// De facut comanda.
		public const string CMD_TAKEPP = "takepp";
		public const string CMD_TAKEPP_DESC = "Foloseste : /takepp [nume] [suma]";
		public const string PP_TAKED = "{0} ti-a luat {1} puncte premium.";

		// De facut comanda.
		public const string CMD_HEAL = "heal";
		public const string CMD_HEAL_DESC = "Foloseste : /heal [nume]";
		public const string PLAYER_HEALED = "{0} a primit heal de la {1}.";
		#endregion
		// ======================= Admin Commands =======================

		// ======================= Job Info =======================
		#region JOB_INFORMATIONS
		public const string JOB_INFO_JOB_SELECTED = "Ai ales jobul : {0}.";
		public const string JOB_INFO_JOB_FINISHED = "Ai castigat {0}$ pentru finalizarea jobului.";
		public const string JOB_INFO_JOB_ABANDONED = "Ai renuntat la job.";

		public const string JOB_INFO_GARBAGE_COLLECTED = "Gunoiul a fost colectat.";
		#endregion
		// ======================= Job Info =======================

		// ======================= Descriptions =======================
		#region DESCRIPTIONS
		public const string DESC_UNEMPLOYED = "Descriere ENEMPLOYED.";
		public const string DESC_TRUCKER = "Descriere TRUCKER.";
		public const string DESC_GARBAGE = "Descriere GARBAGE.";
		#endregion
		// ======================= Descriptions =======================


		// ======================= Login & Register =======================
		#region LOGIN_REGISTER
		public const string YOU_ARE_BANNED = "Contul este banat pentru {0} {1}";
		public const string YOU_ARE_PERMA_BANNED = "Contul este banat PERMANENT";
		public const string SUCCESSFULLY_LOGIN = "Te-ai conectat cu succes";
		public const string SUCCESSFULLY_CREATED = "Contul a fost creat cu succes";
		public const string ACCOUNT_NOT_EXIST = "Contul nu exista";
		public const string USERNAME_USED = "Numele de utilizator este folosit";
		#endregion
		// ======================= Login & Register =======================

	}

}