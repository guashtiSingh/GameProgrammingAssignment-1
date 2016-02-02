using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//Public Instance Variables

	public int catNumber = 3;

	public CatController cat;

	// Use this for initialization
	void Start () {
		this._initialize ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void _initialize (){
		for (int catCount = 0; catCount < this.catNumber; catCount++) {
			Instantiate (cat.gameObject);
		}
	}
}
