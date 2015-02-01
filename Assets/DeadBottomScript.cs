using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeadBottomScript : MonoBehaviour {

	public GameState gameState;
	public BallSpawnerScript ballSpawner;
	public SoundPlayerScript soundPlayer;

	void OnTriggerEnter2D(Collider2D other) {
		soundPlayer.PlayBallHitsDeadBottom();
		Destroy(other.gameObject);
		gameState.OnBallDestroyed();
		ballSpawner.SpawnBall();
	}
}
