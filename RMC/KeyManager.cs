using System;
using RAGE;

namespace RMC_KeyBinder {

	public class KeyManager : Events.Script {
		private static bool _keyStatus = true;

		// Lista butoane :
		public const int Left_Ctrl = 0xA2;
		// .. adaug toate butoanele.

		public static void KeyDown(int key, Action action) {
			if (Input.IsDown(key) && _keyStatus == false) {
				action.Invoke();
				_keyStatus = true;
			}
			else if (Input.IsUp(key)) {
				_keyStatus = false;
			}
		}

		public static void KeyDownAndUp(int key, Action firstAction_down, Action secondAction_up) {
			if (Input.IsDown(key) && _keyStatus == false) {
				firstAction_down.Invoke();
				_keyStatus = true;
			}
			else if (Input.IsUp(key) && _keyStatus == true) {
				secondAction_up.Invoke();
				_keyStatus = false;
			}
		}

	}
}