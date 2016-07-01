using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	GameManager gm;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find ("GameObject");
		gm = go.GetComponent(typeof(GameManager)) as GameManager;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector3 pos = Input.mousePosition;
			float x = transform.position.x -pos.x;
			float y = transform.position.y - pos.y;
			if(x > -50 && x < 50 && y > -50 && y < 50){
				transform.localPosition = new Vector3 ((Random.value - 0.5f) * 300.0f, (Random.value -0.5f) * 300.0f, 0);
				gm.addScore();
			}
		}
	}
}
