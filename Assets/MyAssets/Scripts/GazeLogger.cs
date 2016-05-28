using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GazeLogger : MonoBehaviour {

	public GameObject head;
	CardboardHead ch;
	Text gazeLogger;
	bool showText;
	Rigidbody rb;

	void Awake() {
		gazeLogger = GetComponent<Text> ();
		ch = head.GetComponent<CardboardHead> ();
//		print (gazeLogger);
	}
	// Use this for initialization
	void Start () {
		Cardboard.SDK.OnTrigger += PullTrigger;
		showText = true;
	}

	void PullTrigger ()
	{
		showText = showText ? false : true;
	}
		

	
	// Update is called once per frame
	void Update () {
		if (showText) {
			Ray gaze = ch.Gaze;
			gazeLogger.text = gaze.ToString ();
		} 
		else {
			gazeLogger.text = "";
		}
	}
}
