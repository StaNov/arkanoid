using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public void GoToNextLevel() {
		int loadedLevel = Application.loadedLevel;

		Application.LoadLevel(loadedLevel + 1);
	}
}
