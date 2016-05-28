using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] lanePrefabs;
	public float spawnHorizon;
	public float laneWidth;
	float nextLaneOffset;
	public Transform laneParent;

	public GameObject player;

	// Use this for initialization
	void Start () {
		spawnHorizon = 500.0f;
		laneWidth = 2f;
		nextLaneOffset = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = player.transform.position.z;

		while (distance + spawnHorizon > nextLaneOffset) {
			int lanePrefabIndex = Random.Range (0, lanePrefabs.Length);
			GameObject lane = lanePrefabs [lanePrefabIndex];
			Vector3 nextLanePosition = Vector3.forward * nextLaneOffset;
			GameObject newLane = Instantiate(lane,nextLanePosition, Quaternion.identity) as GameObject;
			newLane.transform.parent = laneParent;
			nextLaneOffset += laneWidth;
		}
	
	}
}
