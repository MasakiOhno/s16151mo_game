using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour {
	public Text txtCompass;
	public Text txtGyro;

	// Use this for initialization
	void Start () {
		Input.compass.enabled = true;
		Input.gyro.enabled = true;

		if (!Input.compass.enabled)
			txtCompass.text = "No Compass";
		if (!SystemInfo.supportsGyroscope)
			txtGyro.text = "No Gyro";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.compass.enabled) {
			txtCompass.text = string.Format("{0:f2}deg", Input.compass.magneticHeading);
		}

		// ジャイロセンサー
		if (SystemInfo.supportsGyroscope && Input.gyro.enabled)
		{
			Vector3 gyro = Input.gyro.rotationRate;
			txtGyro.text = string.Format("X: {0:f1}, Y: {1:f1}, Z:{2:f1}", gyro.x, gyro.y, gyro.z);
		}
	}
}
