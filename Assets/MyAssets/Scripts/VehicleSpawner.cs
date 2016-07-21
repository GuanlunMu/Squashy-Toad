using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

	public GameObject[] vehiclePrefabs;

	float heightOffset = 1; 
	float startOffset = -10;
	public float vehicleSpeed = 5.0f;
	public float vehicleLifeLength = 10.0f;

	void Awake() {
	}

	// Use this for initialization
	void Start () {
		Vector3 vehiclePositon = transform.position + Vector3.up * heightOffset + Vector3.right * startOffset;
		GameObject vehicleObject = Instantiate (vehiclePrefabs[0], vehiclePositon , transform.rotation) as GameObject;
		VehicleBehaviour vehicleScript = vehicleObject.GetComponent<VehicleBehaviour> ();
		vehicleScript.setSpeed (vehicleSpeed, vehicleLifeLength);
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
