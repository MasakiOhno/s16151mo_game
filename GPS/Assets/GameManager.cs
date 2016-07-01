using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text label;
	public RawImage img;
	public AudioSource audioSource;
	public AudioClip audioClip;


	private LocationService GPS;
	private float lat, lng;
	private WWW dlImage;

	// Use this for initialization
	void Start () {
		GPS = Input.location;

		if (GPS.isEnabledByUser)
		{
			
			GPS.Start();


			InvokeRepeating("GetLocation", 0, 5);
		}
		else
		{
			
			label.text = "GPS不許可";
		}


		lat = 35.686275f;
		lng = 139.752835f;
		StartCoroutine(GetMapImage());

		audioSource = gameObject.GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			audioSource.Play();
		}
		if (Input.GetKeyDown(KeyCode.A)) {
			audioSource.clip = audioClip;
		} 
		if (Input.GetKeyDown(KeyCode.S)){
			audioSource.PlayOneShot( audioClip );
		}
		if(Input.GetKeyDown(KeyCode.D)){
			audioSource.Stop( );
		}
		if(Input.GetKeyDown(KeyCode.F)){
			audioSource.Pause( );
		}
		if(Input.GetKeyDown(KeyCode.G)){
			audioSource.UnPause( );
		}
	}

	void onDisable()
	{
		
		GPS.Stop();
	}


	void GetLocation()
	{
		switch (GPS.status)
		{
		case LocationServiceStatus.Failed:
			
			label.text = "取得失敗";
			CancelInvoke("GetLocation");
			break;

		case LocationServiceStatus.Initializing:
			
			label.text = "取得中…";
			break;

		case LocationServiceStatus.Running:
			
			var data = GPS.lastData;
			if (lat != data.latitude || lng != data.longitude)
			{
				
				lat = data.latitude;
				lng = data.longitude;
				StartCoroutine(GetMapImage());
			}
			break;
		}
	}


	IEnumerator GetMapImage()
	{
		label.text = string.Format("緯度:{0:f6}\n経度:{1:f6}", lat, lng);


		var url = "http://maps.googleapis.com/maps/api/staticmap";
		url += string.Format("?center={0},{1}", lat, lng);
		url += "&zoom=14&size=400x300&scale=2&maptype=roadmap&sensor=true";
		url += string.Format("&markers={0},{1}", lat, lng);
		Debug.Log(url);


		dlImage = new WWW(url);
		yield return dlImage;


		img.texture = dlImage.texture;


	}
}


