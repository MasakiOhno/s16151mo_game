using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public Text t;
	int score;
	float time;

	// Use this for initialization
	void Start () {
		
		score = 0;
		time = 10.0f;

	}
	
	// Update is called once per frame
	void Update () {
		
		time -= Time.deltaTime;
		if (time >= 0.0f){
			if (Input.GetKeyDown(KeyCode.A))
			{
				score++;
			}
			t.text = string.Format ("score:{0} time:{1:f1}", score, time);
		} else {
			t.text = string.Format ("score:{0} finished!", score);
		}
    }
}
