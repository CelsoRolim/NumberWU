using UnityEngine;
using System.Collections;

// Empty object used to attach the method to a button onclick event.

public class EmptyLevelMangerScript : MonoBehaviour {

	// method to load new level
	public void loadLevel(string newLevel) {
		Debug.Log ("Level (" + newLevel + ") will be loaded.");
	}

	// method to process the quit request
	public void quitRequestButton() {
		Debug.Log ("Quit game requested. Quiting game...");
	}
}
