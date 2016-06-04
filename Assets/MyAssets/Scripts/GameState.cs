using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void resetGame() {
		SceneManager.LoadScene ("Main");
	}

	public void backToMenu() {
		SceneManager.LoadScene ("Splash");
	}
}

