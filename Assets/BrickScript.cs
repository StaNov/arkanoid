using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	private GameState gameState;

	void Start() {
		gameState = GameObject.Find ("GameState").GetComponent<GameState> ();
	}

	void OnCollisionEnter2D(Collision2D other) {
		GetComponent<MeshRenderer> ().enabled = false;
		GetComponent<BoxCollider2D> ().enabled = false;
		GetComponentInChildren<ParticleSystem> ().Play();
		GetComponent<AudioSource>().Play();
		StartCoroutine ("DestroyAfterSecond");
		gameState.destroyBrick ();
	}

	IEnumerator DestroyAfterSecond() {
		yield return new WaitForSeconds(1);
		Destroy (gameObject);
	}
}
