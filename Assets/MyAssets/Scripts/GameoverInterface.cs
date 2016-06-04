using UnityEngine;
using System.Collections;

public class GameoverInterface : MonoBehaviour {

	private Player playerScript;
	public float UIDistance;
	public float UIHeight;

	void Awake() {
		playerScript = GameObject.FindObjectOfType<Player> ();
	}
	// Use this for initialization
	void Start () {
		UIDistance = 200.0f;
		UIHeight = 95.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerLookDirection = playerScript.GetLookDirection ();
		transform.rotation = Quaternion.LookRotation (playerLookDirection);
		transform.position = playerScript.transform.position + playerLookDirection * UIDistance;
		transform.position += Vector3.up * UIHeight;
	}
}
