using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	//Private Instance Variables
	private int _livesValue;
	private int _scoreValue;

	//Public Access Methods
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}	

		}
	}

	//Public Instance Variables
	public int catNumber = 3;
	public CatController cat;
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public MouseController mouse;
	public CheeseController cheese;

	// Use this for initialization
	void Start () {
		this._initialize ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void _initialize (){

		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.enabled = false;

		for (int catCount = 0; catCount < this.catNumber; catCount++) {
			Instantiate (cat.gameObject);
		}
	}

	private void _endGame() {
		this.GameOverLabel.enabled = true;
		this.mouse.gameObject.SetActive(false);
		this.cheese.gameObject.SetActive(false);
	}
}
