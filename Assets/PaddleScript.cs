using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	public float minX;
	public float maxX;
	public float paddleSpeed = 1;
	public GameState gameState;
	
	void Update () {

		if (gameState.isGameOver()) {
			return;
		}

		float newX = transform.position.x + Input.GetAxis ("Horizontal") * paddleSpeed;

		if (newX < minX)
			newX = minX;

		if (newX > maxX)
			newX = maxX;

		transform.position = new Vector2 (newX, transform.position.y);
	}
}
