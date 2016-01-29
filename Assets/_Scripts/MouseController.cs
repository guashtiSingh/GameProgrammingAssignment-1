using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {
	//Public Instance Variables
	public float speed = 5;

	//Private Instance variable
	private float _mouseInput;
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;

		this._mouseInput = Input.GetAxis ("Vertical");
		//if mouse input is positive move up
		if (this._mouseInput > 0) {
			this._currentPosition += new Vector2 (0, this.speed);
		}

		//if mouse input is positive move down
		if (this._mouseInput < 0) {
			this._currentPosition -= new Vector2 (0, this.speed);
		}

		//Boundary Check
		this._checkBounds ();

		this._transform.position = this._currentPosition;

	}

	//Private Methods
	private void _checkBounds() {
		
		if (this._currentPosition.y < -210) {
			this._currentPosition.y = -210;
		}

		if (this._currentPosition.y > 210) {
			this._currentPosition.y = 210;
		}
	}
}
