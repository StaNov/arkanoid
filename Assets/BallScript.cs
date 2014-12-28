using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public float ballSpeed = 400;

	void Start () {
		rigidbody2D.AddForce (new Vector2 (ballSpeed, ballSpeed));
	}

	void OnCollisionEnter2D(Collision2D other) {
		GetComponent<AudioSource> ().Play ();
	}
}
