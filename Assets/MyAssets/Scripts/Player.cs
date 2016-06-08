using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody rb;
	CardboardHead head;
	FireWall fireWall;
	public float power;
	bool flying;
	bool playerIsDead;

	void Awake() {
		rb = GetComponent<Rigidbody> ();
		head = FindObjectOfType<CardboardHead> ();
		fireWall = FindObjectOfType<FireWall> ();
	}

	// Use this for initialization
	void Start () {
		flying = false;
		power = 5.0f;
		Cardboard.SDK.OnTrigger += Move;
	}

	void Move ()
	{
		if (!playerIsDead && !flying) {
			Vector3 jumpVector = Vector3.RotateTowards (GetLookDirection(), Vector3.up, 1.0f, 0.0f);
			rb.velocity = jumpVector * power;
			flying = true;

		}

	}

	public Vector3 GetLookDirection() {
		return Vector3.ProjectOnPlane (head.Gaze.direction, Vector3.up);
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity == Vector3.zero) {
			flying = false;
		}
		playerIsDead = fireWall.playerIsDead ();
	}
}
