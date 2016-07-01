using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text label;
	public RawImage canvas;
	WebCamTexture video;
	int score = 0;

	int highScore = 0;
	string highScoreKey="highScore";


	// Use this for initialization
	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;

		if (devices.Length > 0){

			label.text = "Camera:"+devices.Length+"\n";
			for(int i=0;i <devices.Length;i++) {
				label.text += "ID:"+i+
					" Name:"+devices[i].name+
					" isFront:"+devices[i].isFrontFacing+"\n";
			}

			//video = new WebCamTexture();
			video = new WebCamTexture(devices[0].name,300,300,10);
			canvas.texture = video;
			video.Play();

		}
		else {
			label.text = "Error: No Camera";
		}

		highScore = PlayerPrefs.GetInt (highScoreKey, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void calcScore(){
		score = 0;
		for (int x=0; x<300; x++) {
			for (int y=0; y<300; y++) {
				Color32 col=video.GetPixel (x,y);
				if((x>=100&&x<200)||(y>=100&&y<200)){
					score += col.r+col.g+col.b;
				}
				else{
					score -= col.r+col.g+col.b;
				}
			}
		}
		score /= 10000;
		label.text = "score:"+score;

		if(score>highScore){
			highScore=score;
			// ハイスコアを保存する
			PlayerPrefs.SetInt (highScoreKey, highScore);
			PlayerPrefs.Save ();
		}
		label.text= "score:"+score+"\n"+"highScore:"+highScore;

	}
}


