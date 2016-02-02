using UnityEngine;
using System.Collections;

public class MouseCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Cheese")) {

		}

		if (other.gameObject.CompareTag ("Cat")) {

		}
	}
}
