using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesCountScript : MonoBehaviour {

	public GameState gameState;

	void Update () {
		GetComponent<Text> ().text = gameState.getLifes().ToString();
	}
}
