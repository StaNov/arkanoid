using UnityEngine;
using System.Collections;

public class BallSpawnerScript : MonoBehaviour {

	public GameObject ballPrefab;
	public GameState gameState;


	public void SpawnBall() {
		if (! gameState.isGameOver ()) {
			Instantiate (ballPrefab, transform.position, transform.rotation);
		}
	}
}
