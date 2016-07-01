using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text t;
	int score=0;
	float time=30.0f;
	public GameObject EnemyPrefab;
	const int ENEMY_NUM = 3;
	GameObject[] enemy = new GameObject[ENEMY_NUM];

	// Use this for initialization
	void Start () {
		for(int i=0;i <ENEMY_NUM;i++){
			enemy[i]= (GameObject) Instantiate (EnemyPrefab);
			Vector3 p= enemy[i].transform.position;
			p.x = (Random.Range (0,2)*2 -1 )*2;
			p.y = (Random.Range (0,2)*2 -1 )*2;
			enemy[i].transform.position = p;
		}

	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time >= 0.0f) {
			t.text = string.Format ("score:{0} time:{1:f1}", score, time);
		} else {
			t.text = string.Format ("score:{0} finished!", score);
		}

	}
	public void AddScore(int s){
		if (time >= 0.0f) {
			score += s;
		}
	}

}

