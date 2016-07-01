using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	GameObject pauseWindow;
	GameObject canvasWindow;

	// Use this for initialization
	void Start () {
		pauseWindow = GameObject.Find ("PauseCanvas");
		canvasWindow = GameObject.Find ("Canvas");
		pauseWindow.GetComponent<Canvas> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
		//	Application.LoadLevel ("Title");
		}



	}

	public void changePauseState(){
		if(canvasWindow.GetComponent<Canvas> ().enabled){
			pauseWindow.GetComponent<Canvas> ().enabled = true;
			canvasWindow.GetComponent<Canvas> ().enabled = false;
		}
		else {
			pauseWindow.GetComponent<Canvas> ().enabled = false;
			canvasWindow.GetComponent<Canvas> ().enabled = true;
		}
	}
}
