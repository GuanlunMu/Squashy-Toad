using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

	public GameObject firePrefabs; 
	public GameObject player;
	public float movingSpeed;

	Vector3 previousPlayerPosition;
	GameObject fireWall;
	GameObject gameState;

	void Awake() {
		gameState = GameObject.Find("GameState");
	}

	Vector3 getFirePosition(Vector3 playerPosition) {
		return new Vector3 (playerPosition.x, 1.0f, playerPosition.z-1);
	}

	public bool playerIsDead() {
		return fireWall.transform.position.z > player.transform.position.z;
	}

	void moveAlongPlayer() {
		Vector3 currentPlayerPosition = player.transform.position;
		if (currentPlayerPosition.x != previousPlayerPosition.x) {
			fireWall.transform.position = getFirePosition (currentPlayerPosition);
			previousPlayerPosition = currentPlayerPosition;
		}
	}
		
	// Use this for initialization
	void Start () {
		movingSpeed = 0.2f;
		previousPlayerPosition = player.transform.position;
		fireWall = Instantiate (firePrefabs, getFirePosition(previousPlayerPosition), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (!playerIsDead ()) {
			moveAlongPlayer ();
			fireWall.transform.position += (Vector3.forward * movingSpeed * Time.deltaTime);
		}
		if (playerIsDead ()) {
			gameState.GetComponent<GameState> ().showGameOverInterface ();
		}
	}
}
