using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class YellowBall : MonoBehaviour {
	public Text t;
	int score=0;
	float time=30.0f;
	int jumpcount = 0;
	const int MAX_JUMP_COUNT = 2;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update (){
		time -= Time.deltaTime;
		if (time >= 0.0f) {
			t.text = string.Format ("score:{0} time:{1:f1}", score, time);
		} else {
			t.text = string.Format ("score:{0} finished!", score);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (transform.right *0.05f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (transform.right *-0.05f);
		}

		if (Input.GetKeyDown (KeyCode.Space) && jumpcount < MAX_JUMP_COUNT) {
			transform.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 5, 0);
			jumpcount++;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "RedBall" ||collision.gameObject.name == "RedBall 1") {
			collision.gameObject.transform.position = new Vector3 ((Random.value - 0.5f) * 6.0f, Random.value * 2.0f, 0);
			if (time >= 0.0f) {
				score++;
			}
		}
		jumpcount = 0;
	}

	void OnMouseDown(){
		transform.GetComponent<Rigidbody2D>().velocity = new Vector3(0,5,0);
	}
}