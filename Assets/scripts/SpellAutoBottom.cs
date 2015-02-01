using UnityEngine;
using System.Collections;

public class SpellAutoBottom : MonoBehaviour {

	public int lifetime = 5;

	private int remainingLifetime;
	
	void Start() {
		remainingLifetime = lifetime;

		StartCoroutine(SubtractSecond());
	}

	IEnumerator SubtractSecond() {

		while (remainingLifetime > 0) {
			yield return new WaitForSeconds(1);
			remainingLifetime--;
		}
	
		Destroy(gameObject);
	}
}
