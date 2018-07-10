using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
public class GameState : MonoBehaviour {

	// Use this for initialization
	PlayersData data;
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
	public GameObject trainLockButton;
	public GameObject airLockButton;
	public GameObject waterLockButton;
	public GameObject skiLockButton;
	public static int playerHigh;
	public static int playerCoins;
	public static bool isTrainUnlocked;
	public static bool isWaterUnlocked;
	public static bool isAirUnlocked;
	public static bool isSkiUnlocked;

	//ParticleFx//
	public GameObject carExhaust;
	public GameObject planeExhaust;
	public GameObject boatExhaust;
	public GameObject trainExhaust;
	public Text myCoins;
	void Start () {
		string js = ResourceHelper.ReadFromPersistentData("gamestate.json");
		data = ResourceHelper.DecodeObject<PlayersData>(js);
		playerHigh = data.Players[0].highScore;
		playerCoins = data.Players[0].coins;
		isTrainUnlocked = data.Players[0].trainUnlocked;
		isWaterUnlocked = data.Players[0].waterUnlocked;
		isAirUnlocked = data.Players[0].airUnlocked;
		isSkiUnlocked = data.Players[0].skiUnlocked;
		print(playerCoins);
		if(data.Players[0].isLoaded==true){
			myCoins.text = playerCoins.ToString();
		}
		if(isTrainUnlocked == true){
			//Destroy(trainLockButton);
			trainLockButton.SetActive(false);
		}
		if(isAirUnlocked == true){
			airLockButton.SetActive(false);
		}
		if(isWaterUnlocked == true){
			waterLockButton.SetActive(false);
		}
		if(isSkiUnlocked == true){
			skiLockButton.SetActive(false);
		}
		if(data.Players[0].isAir == true){
			road.SetActive(false);
			roadBg.SetActive(false);
			railway.SetActive(false);
			railBG.SetActive(false);
			snow.SetActive(false);
			snowBG.SetActive(false);
			water.SetActive(false);
			waterBG.SetActive(false);
			air.SetActive(true);
			airBg.SetActive(true);
			FinalScore.air = true;
			FinalScore.train = false;
			FinalScore.water = false;
			FinalScore.ski = false;
			FinalScore.road = false;
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

		if(data.Players[0].isRoad == true){
			road.SetActive(true);
			roadBg.SetActive(true);
			air.SetActive(false);
			airBg.SetActive(false);
			railway.SetActive(false);
			railBG.SetActive(false);
			snow.SetActive(false);
			snowBG.SetActive(false);
			water.SetActive(false);
			waterBG.SetActive(false);
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

		if(data.Players[0].isTrain==true){
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
	if(data.Players[0].isWater==true){
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
	if(data.Players[0].isSki==true){
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
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
