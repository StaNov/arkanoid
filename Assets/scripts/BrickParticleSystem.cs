using UnityEngine;
using System.Collections;

public class BrickParticleSystem : MonoBehaviour {

	private ParticleSystem ps;

	void Start () {
		ps = GetComponent<ParticleSystem>();
	}

	public void PlayAndDestroy() {
		transform.parent = null;
		ps.Play();
		Destroy (gameObject, 1);
	}
}
