using UnityEngine;
using System.Collections;

public class ScreenSettings : MonoBehaviour {

	void Awake () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
}
