using UnityEngine;
using System.Collections;

public class KitchenController : MonoBehaviour {
	//Public Instance Variables
	public float speed = 5;

	//Private Instance Variables
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {

		// Make a reference with the transform component
		this._transform = gameObject.GetComponent<Transform> ();

		//Reset the kitchen sprite to the top
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this.speed, 0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -640) {
			this.Reset ();
		}
	}

	public void Reset() {
		this._transform.position = new Vector2 (640f, 0);
	}
}
