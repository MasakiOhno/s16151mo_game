using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Image image;

	public Text webt;
	public Text t;
	int score=0;
	string pname="nanashi";
	float time= 20.0f;

	// Use this for initialization
	void Start () {
		
		IEnumerator coroutine = LoadImage("http://web.sfc.keio.ac.jp/~wadari/sdp/k07_web/Player.png");
		StartCoroutine(coroutine);
	}


	IEnumerator LoadImage(string url)
	{
		
		WWW loader = new WWW(url);


		yield return loader;


		if (!string.IsNullOrEmpty(loader.error)) {
			
			print("WWW Error");
		}
		else
		{
			
			Texture2D tex = loader.texture;
			Rect rect = new Rect(0, 0, tex.width, tex.height);
			Vector2 pivot = new Vector2(0.5f, 0.5f);
			image.sprite = Sprite.Create(tex, rect, pivot);
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
	public void sendScore ()
	{
		
		string send_url = "http://web.sfc.keio.ac.jp/~wadari/sdp/k07_web/score.cgi?score="+score+"&name="+pname;
		IEnumerator coroutine = LoadText(send_url);
		StartCoroutine(coroutine);
	}
	    
	IEnumerator LoadText(string url)
	{
		
		WWW loader = new WWW(url);


		yield return loader;


		if (!string.IsNullOrEmpty(loader.error))
		{
			
			print("WWW Error");
		}
		else
		{
			
			webt.text = loader.text;
		}
	}
	public void addScore(){
		if (time > 0) {
			score++;
		}
	}

	public void restart(){
		score = 0;
		time = 20.0f;
	}

}
