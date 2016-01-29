using UnityEngine;
using System.Collections;

public class CheeseController : MonoBehaviour {

	//Public Instance Variables
	public float speed = 5f;

	//Private Instance Variables
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {

		// Make a reference with the transform component
		this._transform = gameObject.GetComponent<Transform> ();

		//Reset the Cheese sprite to the top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this.speed, 0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -345) {
			this.Reset ();
		}
	}

	public void Reset() {
		float yPosition = Random.Range (-210f, 210f);
		this._transform.position = new Vector2 (345f, yPosition);
	}
}
