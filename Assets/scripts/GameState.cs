using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	public GameObject gameOverPanel;
	public BallSpawnerScript ballSpawner;
	public SoundPlayerScript soundPlayer;
	public Transform bricksParent;

	public int lives = 3;

	void Start() {
		ballSpawner.SpawnBall ();
	}
	
	public void OnBallDestroyed() {
		lives--;
		ShowGameOverScreenIfGameOver (false);
	}
	
	public void OnBrickDestroyed() {
		StartCoroutine(ShowGameOverScreenIfGameOverNextFrame());
	}
	
	private IEnumerator ShowGameOverScreenIfGameOverNextFrame() {
		yield return new WaitForEndOfFrame();
		ShowGameOverScreenIfGameOver (true);
	}

	public int getLifes() {
		return lives;
	}

	public bool isGameOver() {
		return lives == 0 || bricksParent.childCount == 0;
	}

	private void ShowGameOverScreenIfGameOver(bool win) {
		if (isGameOver()) {
			DestroyAllBalls();
			gameOverPanel.SetActive(true);

			SetGameOverText(win);

			if (win) {
				soundPlayer.PlayWin();
			}
		}
	}

	private void DestroyAllBalls() {
		foreach (GameObject ball in GameObject.FindGameObjectsWithTag ("ball")) {
			Destroy(ball);
		}
	}

	private void SetGameOverText(bool win) {
		gameOverPanel.GetComponentInChildren<Text> ().text = win ? "Vyhrál jsi!" : "Prohrál jsi";
	}
}
