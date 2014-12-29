using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public float ballSpeed = 400;

	private SoundPlayerScript soundPlayer;

	void Start () {
		soundPlayer = GameObject.Find("SoundPlayer").GetComponent<SoundPlayerScript>();
		rigidbody2D.AddForce (new Vector2 (ballSpeed, ballSpeed));
	}

	void OnCollisionEnter2D(Collision2D other) {
		soundPlayer.PlayBallHitsWall();
	}
}
