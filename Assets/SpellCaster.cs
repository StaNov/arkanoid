using UnityEngine;
using System.Collections;

public class SpellCaster : MonoBehaviour {

	public GameObject spellAutoBottom;
	public BallSpawnerScript ballSpawner;
	
	public void SpawnAutoBottom() {
		Instantiate(spellAutoBottom);
	}
	
	public void SpawnNewBall() {
		ballSpawner.SpawnBall();
	}
}
