using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour {

	//Public Instance Variables
	public float minHorizontalSpeed = 5f;
	public float maxHorizontalSpeed = 10f;
	public float minVerticalSpeed = -2f;
	public float maxVerticalSpeed = 2f;

	//Private Instance Variables
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalSpeed;
	private float _verticalDrift;

	// Use this for initialization
	void Start () {

		// Make a reference with the transform component
		this._transform = gameObject.GetComponent<Transform> ();

		//Reset the Cat sprite to the top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -385) {
			this.Reset ();
		}
	}

	public void Reset() {
		this._horizontalSpeed = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		this._verticalDrift = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		float yPosition = Random.Range (-210f, 210f);
		this._transform.position = new Vector2 (385f, yPosition);
	}
}
