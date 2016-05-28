using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	Text score;
	Button startGame;

	void Awake() {
//		score = GameObject.Find ("Score");
//		startGame = GameObject.Find ("Start Game");
	}

	// Use this for initialization
	void Start () {
//		score.text = 300 + " meters";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGame() {
		SceneManager.LoadScene ("Main");
	}
}
