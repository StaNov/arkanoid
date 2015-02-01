using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	private GameState gameState;
	private SoundPlayerScript soundPlayer;

	public int hitPoints = 1;
	private int remainingHits;

	void Start() {
		gameState = GameObject.Find ("GameState").GetComponent<GameState> ();
		soundPlayer = GameObject.Find ("SoundPlayer").GetComponent<SoundPlayerScript> ();
		remainingHits = hitPoints;
	}

	void OnCollisionEnter2D(Collision2D other) {
		remainingHits--;

		if (remainingHits == 0) {
			DestroyBrick();
		}
	}

	private void DestroyBrick() {
		GetComponent<MeshRenderer> ().enabled = false;
		GetComponent<BoxCollider2D> ().enabled = false;
		BrickParticleSystem particleSystem = GetComponentInChildren<BrickParticleSystem> ();
		particleSystem.PlayAndDestroy();
		soundPlayer.PlayBallHitsBrick();
		gameState.OnBrickDestroyed();
		Destroy(gameObject);
	}
}
