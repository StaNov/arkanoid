using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeadBottomScript : MonoBehaviour {

	public GameState gameState;
	public BallSpawnerScript ballSpawner;

	void OnTriggerEnter2D(Collider2D other) {
		GetComponent<AudioSource>().Play();
		Destroy(other.gameObject);
		gameState.loseLife();
		ballSpawner.SpawnBall ();
	}
}
