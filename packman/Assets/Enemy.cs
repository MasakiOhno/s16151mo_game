using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	Animator animator;
	GameObject player;
	float EnemySpeed= 0.01f;

	// Use this for initialization
	void Start () {
		animator = GetComponent <Animator> ();
		animator.Play ("Chara_move");
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		float px, py, ex, ey;

		px = player.transform.localPosition.x;
		py = player.transform.localPosition.y;
		ex = transform.localPosition.x;
		ey = transform.localPosition.y;


		if (ex < px) {
			transform.Translate (transform.right * EnemySpeed);
			Vector3 s =transform.localScale;
			s.x = 1;
			transform.localScale = s;
		} else {
			transform.Translate (transform.right * -EnemySpeed);
			Vector3 s =transform.localScale;
			s.x = -1;
			transform.localScale = s;
		}

		if (ey < py) {
			transform.Translate (transform.up * EnemySpeed);
		} else {
			transform.Translate (transform.up * -EnemySpeed);
		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "Item") {
			collision.gameObject.transform.position = new Vector3 ((Random.value - 0.5f) * 1.5f, (Random.value -0.5f) * 1.5f, 0);
			transform.position = new Vector3 ((Random.Range(0,2)*2-1)*2.0f, (Random.Range(0,2)*2-1)*2.0f, 0);
			EnemySpeed += 0.001f;

			GameObject go = GameObject.Find ("GameObject");
			if(go != null){
				GameManager gm = go.GetComponent<GameManager>();
				gm.AddScore(10);
			}
		}
	}

}


