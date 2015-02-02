using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	public BallSpawnerScript ballSpawner;
	public SoundPlayerScript soundPlayer;
	public Transform bricksParent;
	public GameOverPanelScript gameOverPanel;

	public int lives = 3;

	void Start() {
		ballSpawner.SpawnBall (false);
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

			ShowGameOverPanel(win);

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

	private void ShowGameOverPanel(bool win) {
		if (win) {
			gameOverPanel.ShowVictory();
		} else {
			gameOverPanel.ShowLose();
		}
	}
}
