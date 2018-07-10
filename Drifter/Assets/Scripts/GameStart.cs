using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class GameStart : MonoBehaviour {

	// Use this for initialization
	public GameObject car;
	public GameObject mainCam;
	CarFollow carFollow;
	CarMovement carMovement;
	public GameObject panel;
	public GameObject themePanel;
	public GameObject shopPanel;
	public GameObject settingsPanel;
	public GameObject soundOn;
	public GameObject soundOff;
	void Start () {
		car = GameObject.FindGameObjectWithTag("Car");
		mainCam = GameObject.FindGameObjectWithTag("MainCamera");
		carMovement = car.GetComponent<CarMovement>();
		carFollow = mainCam.GetComponent<CarFollow>();
		panel = GameObject.FindGameObjectWithTag("Panel");
		if(panel.active == true){
			carFollow.enabled = false;
			carMovement.enabled = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void TouchToStart(){
		panel.SetActive(false);
		carFollow.enabled = true;
		carMovement.enabled = true;
	}

	public void Restart(){
		//Advertisement.Show();
		Scene loadLevel = SceneManager.GetActiveScene();
		SceneManager.LoadScene(loadLevel.buildIndex);
	}

	public void ThemePressed(){
		panel.SetActive(false);
		themePanel.SetActive(true);
	}

	public void BackPressed(){
		panel.SetActive(true);
		themePanel.SetActive(false);
	}

	public void SharePressed(){
		float startTime;
		startTime = Time.timeSinceLevelLoad;
		Application.OpenURL("fb://page/tbhproductions");

		if(Time.timeSinceLevelLoad - startTime <=1){
			Application.OpenURL("https://www.facebook.com/tbhproductions/");
		}
		
	}

	public void ShopPressed(){
		shopPanel.SetActive(true);
	}

	public void ShopBackPressed(){
		shopPanel.SetActive(false);
	}

	public void OnSettingsClicked(){
		if(settingsPanel.active == true){
			Debug.Log("Band");
			settingsPanel.SetActive(false);
		}
		if(settingsPanel.active == false){
			Debug.Log("Khul");
			settingsPanel.SetActive(true);
		}
	}

	public void OnSoundOnClick(){
		soundOff.SetActive(true);
	}

	public void OnSoundOffClick(){
		soundOff.SetActive(false);
	}
}
