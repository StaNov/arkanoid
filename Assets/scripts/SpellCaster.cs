using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpellCaster : MonoBehaviour {

	public GameObject spellAutoBottom;
	public Button spellAutoBottomButton;

	public BallSpawnerScript ballSpawner;
	public Button spawnNewBallButton;
	
	public void SpawnAutoBottom() {
		Instantiate(spellAutoBottom);
		DisableButtonForSeconds(spellAutoBottomButton, 10);
	}
	
	public void SpawnNewBall() {
		ballSpawner.SpawnBall(true);
		DisableButtonForSeconds(spawnNewBallButton, 5);
	}

	private void DisableButtonForSeconds(Button button, int secondsDisabled) {
		button.interactable = false;

		StartCoroutine(enableAfterSeconds(button, secondsDisabled));
	}

	private IEnumerator enableAfterSeconds(Button button, int secondsDisabled) {
		yield return new WaitForSeconds(secondsDisabled);

		button.interactable = true;
	}
}
