using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	public float minX;
	public float maxX;
	public float paddleSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float newX = transform.position.x + Input.GetAxis ("Horizontal") * paddleSpeed;

		if (newX < minX)
			newX = minX;

		if (newX > maxX)
			newX = maxX;

		transform.position = new Vector2 (newX, transform.position.y);
	}

	void OnCollisionEnter2D(Collision2D other) {
		//Debug.Log ("kolidujeee!!!");
	}
}
