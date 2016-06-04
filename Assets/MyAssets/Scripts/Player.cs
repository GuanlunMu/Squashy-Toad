using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody rb;
	CardboardHead head;
	public float power;
	bool flying;

	void Awake() {
		rb = GetComponent<Rigidbody> ();
		head = FindObjectOfType<CardboardHead> ();
	}

	// Use this for initialization
	void Start () {
		flying = false;
		power = 5.0f;
		Cardboard.SDK.OnTrigger += Move;
	}

	void Move ()
	{
		print (flying);
		if (!flying) {
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
	}
}
