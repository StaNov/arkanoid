using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverPanelScript : MonoBehaviour {

	private Text text;
	public Button tryAgainButton;
	public Button nextLevelButton;

	void Start () {
		text = GetComponentInChildren<Text> ();

		tryAgainButton.gameObject.SetActive(false);
		nextLevelButton.gameObject.SetActive(false);
		gameObject.SetActive (false);
	}
	
	public void ShowLose() {
		text.text = "Prohrál jsi";
		tryAgainButton.gameObject.SetActive(true);
		gameObject.SetActive(true);
	}
	
	public void ShowVictory() {
		text.text = "Vyhrál jsi!";
		nextLevelButton.gameObject.SetActive(true);
		gameObject.SetActive(true);
	}
}
