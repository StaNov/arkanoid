using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	public GameObject gameOverPanel;
	public BallSpawnerScript ballSpawner;

	public int lives = 3;
	private int bricks = 1;

	public void Start() {
		bricks = GameObject.FindGameObjectsWithTag ("brick").Length;
		ballSpawner.SpawnBall ();
	}
	
	public void loseLife() {
		lives--;
		ShowGameOverScreenIfGameOver (false);
	}
	
	public void destroyBrick() {
		bricks--;
		ShowGameOverScreenIfGameOver (true);
	}

	public int getLifes() {
		return lives;
	}

	public bool isGameOver() {
		return lives <= 0 || bricks <= 0;
	}

	private void ShowGameOverScreenIfGameOver(bool win) {
		if (isGameOver()) {
			DestroyAllBalls();
			gameOverPanel.SetActive(true);

			SetGameOverText(win);

			if (win) {
				GetComponent<AudioSource>().Play();
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
