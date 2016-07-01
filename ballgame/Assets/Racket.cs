using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (transform.right *0.1f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (transform.right *-0.1f);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (transform.up*0.1f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (transform.up *-0.1f);
		}

	}
}
