using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

// Empty object used to attach the method to a button onclick event.

public class EmptyLevelMangerScript : MonoBehaviour {

	// OBS: scene and level are the same.

	// method to load new level
	public void loadLevel(string newLevel) {
		Debug.Log ("Level (" + newLevel + ") will be loaded.");

		// load level "newLevel"
		SceneManager.LoadScene(newLevel);
	}

	// method to process the quit request
	public void quitRequestButton() {
		Debug.Log ("Quit game requested. Quiting game...");

		// Quit game
		// Do not use for mobile projects. It is a bad pattern.
		Application.Quit();
	}
}
