using UnityEngine;
using System.Collections;

public class VehicleBehaviour : MonoBehaviour {

	float speed;
	float length;

	// Use this for initialization
	void Start () {
		float lifeTime = length / speed;
		Invoke ("remove", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (Vector3.right * speed * Time.deltaTime);
	}

	void remove() {
		Destroy (gameObject);
	}
	public void setSpeed(float speed, float length) {
		this.speed = speed;
		this.length = length;
	}
}
