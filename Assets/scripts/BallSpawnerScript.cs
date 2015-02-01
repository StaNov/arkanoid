using UnityEngine;
using System.Collections;

public class BallSpawnerScript : MonoBehaviour {

	public GameObject ballPrefab;
	public GameObject ballTemporaryPrefab;
	public GameState gameState;


	public void SpawnBall(bool temporary) {
		GameObject prefab = temporary ? ballTemporaryPrefab : ballPrefab;

		if (! gameState.isGameOver ()) {
			Instantiate (prefab, transform.position, transform.rotation);
		}
	}
}
