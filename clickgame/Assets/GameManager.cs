using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text t;
	public Toggle tg;
	public Toggle tg1;
	public Toggle tg2;
	public Slider sl;
	public Scrollbar sc;
	public Scrollbar sc1;
	public Text inputtext;
	int score;
	float time;
	string pname;


	// Use this for initialization
	void Start () {
		score = 0;
		time = 20.0f;
		pname = "nanashi";
	
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time >= 0.0f){
			t.text = pname + string.Format ("'s score is{0}pts. time:{1:f1}", score, time);
		} else {
			t.text = pname + string.Format ("'s score is{0}pts. finished!", score);
		}
	}
	public void ToggleChanged(){
		if (tg.isOn==false && tg1.isOn==false && tg2.isOn==false ) {
			if(time >= 0.0f){
				score++;
			}
			int r = Random.Range(0,3);
			if(r==0) tg.isOn=true;
			if(r==1) tg1.isOn=true;
			if(r==2) tg2.isOn=true;
		}
	}
	public void SetColor(){
		t.color = new Color(sl.value, sc.value, sc1.value);
	}
	public void SetName(){
		pname = inputtext.text;
		score = 0;
		time = 20.0f;
		tg.isOn = true;
		tg1.isOn = true;
		tg2.isOn = true;
	}
}
