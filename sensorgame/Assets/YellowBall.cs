using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class YellowBall: MonoBehaviour {
	public Text t;
	int score=0;
	float time=60.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 acce = Input.acceleration;
		float r = 1.0f;
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (acce.x *r,acce.y*r));
		time -= Time.deltaTime;
		if (time >= 0.0f) {
			t.text = string.Format ("score:{0} time:{1:f1}", score, time);
		} else {
			t.text = string.Format ("score:{0} finished!", score);
		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "RedBall") {
			collision.gameObject.transform.position = new Vector3 ((Random.value - 0.5f) * 1.5f, (Random.value -0.5f) * 1.5f, 0);

			if (time >= 0.0f) {
				score++;
			}
		}
	}

}


