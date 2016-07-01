using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text t;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 acce = Input.acceleration;
		t.text = string.Format("x: {0:f4}\ny: {1:f4}\nz: {2:f4}", acce.x, acce.y, acce.z);
	}
}


