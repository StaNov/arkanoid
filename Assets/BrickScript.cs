﻿using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	private GameState gameState;
	private SoundPlayerScript soundPlayer;

	void Start() {
		gameState = GameObject.Find ("GameState").GetComponent<GameState> ();
		soundPlayer = GameObject.Find ("SoundPlayer").GetComponent<SoundPlayerScript> ();
	}

	void OnCollisionEnter2D(Collision2D other) {
		GetComponent<MeshRenderer> ().enabled = false;
		GetComponent<BoxCollider2D> ().enabled = false;
		BrickParticleSystem particleSystem = GetComponentInChildren<BrickParticleSystem> ();
		particleSystem.PlayAndDestroy();
		soundPlayer.PlayBallHitsBrick();
		Destroy(gameObject);
		gameState.OnBrickDestroyed();
	}
}