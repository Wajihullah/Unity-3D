using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThemeSelection : MonoBehaviour {

	// Use this for initialization

	public GameObject road;
	public GameObject air;
	public GameObject railway;
	public GameObject water;
	public GameObject snow;
	public GameObject roadBg;
	public GameObject airBg;
	public GameObject railBG;
	public GameObject waterBG;
	public GameObject snowBG;
	public GameObject car;
	public SpriteRenderer carSprite;
	public GameObject RoadButton;
	public GameObject AirButton;
	public GameObject railButton;
	public GameObject waterButton;
	public GameObject snowButton;

	public GameObject trainLocked;
	public GameObject airLocked;
	public GameObject waterLocked;
	public GameObject skiLocked;
	public Text coinText;

	//Particles//
	public GameObject planeExhaust;
	public GameObject boatExhaust;
	public GameObject carExhaust;
	public GameObject trainExhaust;
	void Start () {
		carSprite = car.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnAirClick(){
		Debug.Log("Hello");
		road.SetActive(false);
		railway.SetActive(false);
		water.SetActive(false);
		snow.SetActive(false);
		roadBg.SetActive(false);
		railBG.SetActive(false);
		waterBG.SetActive(false);
		snowBG.SetActive(false);
		air.SetActive(true);
		airBg.SetActive(true);
		FinalScore.air = true;
		FinalScore.road = false;
		FinalScore.train = false;
		FinalScore.water = false;
		FinalScore.ski = false;

		//Setting Particle Effects//
		planeExhaust.SetActive(true);
		carExhaust.SetActive(false);
		boatExhaust.SetActive(false);
		trainExhaust.SetActive(false);
		Sprite planeSp = Resources.Load<Sprite>("Sprites/plane");
		if(planeSp!=null){
			print("gotcha");
		}
		carSprite.sprite = planeSp;
		Debug.Log("Air Selected");
		AirButton.transform.GetChild(0).gameObject.SetActive(true);
		if(RoadButton.transform.GetChild(0).gameObject.active==true){
			RoadButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(railButton.transform.GetChild(0).gameObject.active==true){
			railButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(waterButton.transform.GetChild(0).gameObject.active==true){
			waterButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(snowButton.transform.GetChild(0).gameObject.active==true){
			snowButton.transform.GetChild(0).gameObject.SetActive(false);
		}
	}

	public void OnRoadClick(){
		road.SetActive(true);
		roadBg.SetActive(true);
		air.SetActive(false);
		airBg.SetActive(false);
		railway.SetActive(false);
		railBG.SetActive(false);
		water.SetActive(false);
		waterBG.SetActive(false);
		snow.SetActive(false);
		snowBG.SetActive(false);
		FinalScore.road = true;
		FinalScore.air = false;
		FinalScore.train = false;
		FinalScore.water = false;
		FinalScore.ski = false;
		//Setting Particle Effects//
		planeExhaust.SetActive(false);
		carExhaust.SetActive(true);
		boatExhaust.SetActive(false);
		trainExhaust.SetActive(false);
		Sprite carSp = Resources.Load<Sprite>("Sprites/car");
		if(carSp!=null){
			print("gotcha");
		}
		carSprite.sprite = carSp;
		carSprite.sprite = carSp;
		Debug.Log("Road Selected");
		RoadButton.transform.GetChild(0).gameObject.SetActive(true);
		if(AirButton.transform.GetChild(0).gameObject.active==true){
			AirButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(railButton.transform.GetChild(0).gameObject.active==true){
			railButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(waterButton.transform.GetChild(0).gameObject.active==true){
			waterButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(snowButton.transform.GetChild(0).gameObject.active==true){
			snowButton.transform.GetChild(0).gameObject.SetActive(false);
		}
	}

	public void onRailClick(){
		railway.SetActive(true);
		railBG.SetActive(true);
		FinalScore.train = true;
		Sprite trainSp = Resources.Load<Sprite>("Sprites/train");
		if(trainSp!=null){
			print("gotcha");
		}
		carSprite.sprite = trainSp;
		railButton.transform.GetChild(0).gameObject.SetActive(true);
		air.SetActive(false);
		airBg.SetActive(false);
		water.SetActive(false);
		waterBG.SetActive(false);
		snow.SetActive(false);
		snowBG.SetActive(false);
		road.SetActive(false);
		roadBg.SetActive(false);
		FinalScore.road = false;
		FinalScore.air = false;
		FinalScore.water = false;
		FinalScore.ski = false;
		//Setting Particle Effects//
		planeExhaust.SetActive(false);
		carExhaust.SetActive(false);
		boatExhaust.SetActive(false);
		trainExhaust.SetActive(true);
		if(AirButton.transform.GetChild(0).gameObject.active==true){
			AirButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(RoadButton.transform.GetChild(0).gameObject.active==true){
			RoadButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(waterButton.transform.GetChild(0).gameObject.active==true){
			waterButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(snowButton.transform.GetChild(0).gameObject.active==true){
			snowButton.transform.GetChild(0).gameObject.SetActive(false);
		}
	}

	public void OnWaterClick(){
		water.SetActive(true);
		waterBG.SetActive(true);
		air.SetActive(false);
		airBg.SetActive(false);
		road.SetActive(false);
		roadBg.SetActive(false);
		railway.SetActive(false);
		railBG.SetActive(false);
		snow.SetActive(false);
		snowBG.SetActive(false);
		FinalScore.water = true;
		FinalScore.train = false;
		FinalScore.road = false;
		FinalScore.air = false;
		FinalScore.ski = false;
		//Setting Particle Effects//
		planeExhaust.SetActive(false);
		carExhaust.SetActive(false);
		boatExhaust.SetActive(true);
		trainExhaust.SetActive(false);
		Sprite boatSp = Resources.Load<Sprite>("Sprites/boat");
		if(boatSp!=null){
			print("gotcha");
		}
		carSprite.sprite = boatSp;
		waterButton.transform.GetChild(0).gameObject.SetActive(true);
		if(AirButton.transform.GetChild(0).gameObject.active==true){
			AirButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(railButton.transform.GetChild(0).gameObject.active==true){
			railButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(RoadButton.transform.GetChild(0).gameObject.active==true){
			RoadButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(snowButton.transform.GetChild(0).gameObject.active==true){
			snowButton.transform.GetChild(0).gameObject.SetActive(false);
		}
	}
	public void OnSnowClick(){
		water.SetActive(false);
		waterBG.SetActive(false);
		air.SetActive(false);
		airBg.SetActive(false);
		road.SetActive(false);
		roadBg.SetActive(false);
		railway.SetActive(false);
		railBG.SetActive(false);
		snow.SetActive(true);
		snowBG.SetActive(true);
		FinalScore.water = false;
		FinalScore.train = false;
		FinalScore.road = false;
		FinalScore.air = false;
		FinalScore.ski = true;
		//Setting Particle Effects//
		planeExhaust.SetActive(false);
		carExhaust.SetActive(false);
		boatExhaust.SetActive(false);
		trainExhaust.SetActive(false);
		Sprite skiSp = Resources.Load<Sprite>("Sprites/ski");
		if(skiSp!=null){
			print("gotcha");
		}
		carSprite.sprite = skiSp;
		snowButton.transform.GetChild(0).gameObject.SetActive(true);
		if(AirButton.transform.GetChild(0).gameObject.active==true){
			AirButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(railButton.transform.GetChild(0).gameObject.active==true){
			railButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(RoadButton.transform.GetChild(0).gameObject.active==true){
			RoadButton.transform.GetChild(0).gameObject.SetActive(false);
		}
		if(waterButton.transform.GetChild(0).gameObject.active==true){
			waterButton.transform.GetChild(0).gameObject.SetActive(false);
		}
	}

	public void OnTrainLockedClick(){
		if(int.Parse(coinText.text)>1200){
			trainLocked.SetActive(false);
			GameState.isTrainUnlocked = true;
			//print(FinalScore.isTrainUnlocked);
			GameState.playerCoins = int.Parse(coinText.text) - 1200;
			coinText.text = GameState.playerCoins.ToString();
		}
	}

	public void OnAirLockedClick(){
		if(int.Parse(coinText.text)>1200){
			airLocked.SetActive(false);
			GameState.isAirUnlocked = true;
			GameState.playerCoins = int.Parse(coinText.text) - 1200;
			coinText.text = GameState.playerCoins.ToString();
		}
	}

	public void OnSkiLockedClicked(){
		if(int.Parse(coinText.text)>1200){
			skiLocked.SetActive(false);
			GameState.isSkiUnlocked = true;
			GameState.playerCoins = int.Parse(coinText.text) - 1200;
			coinText.text = GameState.playerCoins.ToString();
		}
	}

	public void OnWaterLockedClick(){
		if(int.Parse(coinText.text)>1200){
			waterLocked.SetActive(false);
			GameState.isWaterUnlocked = true;
			GameState.playerCoins = int.Parse(coinText.text) - 1200;
			coinText.text = GameState.playerCoins.ToString();
		}
	}
}
