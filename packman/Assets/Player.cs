using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Animator animator;
	float PlayerSpeed= 0.03f;

	// Use this for initialization
	void Start () {
		animator = GetComponent <Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		//上下左右の移動
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (transform.right *PlayerSpeed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (transform.right *-PlayerSpeed);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (transform.up*PlayerSpeed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (transform.up *-PlayerSpeed);
		}


		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			animator.Play ("Chara_move");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			animator.Play ("Chara_move");
		} 
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			animator.Play ("Chara_move");
			Vector3 s = transform.localScale;
			s.x = 1;
			transform.localScale = s;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			animator.Play ("Chara_move");
			Vector3 s = transform.localScale;
			s.x = -1;
			transform.localScale = s;
		}


		if (Input.GetKeyUp (KeyCode.UpArrow) ||
			Input.GetKeyUp (KeyCode.DownArrow) ||
			Input.GetKeyUp (KeyCode.RightArrow) ||
			Input.GetKeyUp (KeyCode.LeftArrow)) {
			animator.Play ("Chara_idle");
		}


		if (Input.GetKeyDown(KeyCode.Space)) {
			animator.Play ("Chara_damaged");
		}

	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "Enemy") {
			animator.Play ("Chara_damaged");
		}

		GameObject go = GameObject.Find ("GameObject");
		if(go != null){
			GameManager gm = go.GetComponent<GameManager>();
			gm.AddScore(-30);
		}
	}
}
	
