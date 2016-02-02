using UnityEngine;
using System.Collections;

public class MouseCollider : MonoBehaviour {

	//Private Instance variables
	private AudioSource[] _audioSources;
	private AudioSource _cheeseSound;
	private AudioSource _catSound;


	// Use this for initialization
	void Start () {
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._catSound = this._audioSources [1];
		this._cheeseSound = this._audioSources[2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Cheese")) {
			this._cheeseSound.Play ();
		}

		if (other.gameObject.CompareTag ("Cat")) {
			this._catSound.Play ();
		}
	}
}
