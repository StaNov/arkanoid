using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayerScript : MonoBehaviour {

	private AudioSource audioSource;

	public AudioClip ballHitsWall;
	public AudioClip ballHitsDeadBottom;
	public AudioClip ballHitsBrick;
	public AudioClip win;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	public void PlayBallHitsWall() {
		Play(ballHitsWall);
	}
	
	public void PlayBallHitsDeadBottom() {
		Play(ballHitsDeadBottom);
	}
	
	public void PlayBallHitsBrick() {
		Play(ballHitsBrick);
	}
	
	public void PlayWin() {
		Play(win);
	}
	
	private void Play(AudioClip clip) {
		audioSource.Stop();
		audioSource.PlayOneShot(clip);
	}
	
}
