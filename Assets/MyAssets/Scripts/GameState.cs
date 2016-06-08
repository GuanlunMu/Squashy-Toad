using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

	GameObject gameOverInterface;

	void Awake() {
		gameOverInterface = GameObject.Find ("GameoverInterface");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void showGameOverInterface() {
		gameOverInterface.SetActive (true);
	}
	public void resetGame() {
		SceneManager.LoadScene ("Main");
	}

	public void backToMenu() {
		SceneManager.LoadScene ("Splash");
	}
}

