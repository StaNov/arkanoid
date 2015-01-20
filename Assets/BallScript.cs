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
	
	void OnCollisionExit2D(Collision2D other) {
		float velX = rigidbody2D.velocity.x;
		float velY = rigidbody2D.velocity.y;

		if (Mathf.Abs(velX) > Mathf.Abs(velY)) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(new Vector2(ballSpeed * velX/Mathf.Abs(velX), ballSpeed * velY/Mathf.Abs(velY)));
		}
	}
}
