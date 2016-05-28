using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

	public GameObject firePrefabs; 
	public GameObject player;
	public float movingSpeed;

	Vector3 previousPlayerPosition;
	GameObject fireWall;

	Vector3 getFirePosition(Vector3 playerPosition) {
		return new Vector3 (playerPosition.x, 1.0f, playerPosition.z-1);
	}

	void moveAlongPlayer() {
		Vector3 currentPlayerPosition = player.transform.position;
		if (currentPlayerPosition.x != previousPlayerPosition.x) {
			fireWall.transform.position = getFirePosition (currentPlayerPosition);
			previousPlayerPosition = currentPlayerPosition;
		}
	}

//	void autoMoveForward() {
//		fireWall.transform.position.z += (movingSpeed * Time.deltaTime);
//	}

	// Use this for initialization
	void Start () {
		movingSpeed = 0.2f;
		previousPlayerPosition = player.transform.position;
		fireWall = Instantiate (firePrefabs, getFirePosition(previousPlayerPosition), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		moveAlongPlayer ();
		fireWall.transform.position += (Vector3.forward * movingSpeed * Time.deltaTime);
	}
}
