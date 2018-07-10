using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour {

	// Use this for initialization
	public static int finalScore;
	public static bool air;
	public static bool road;
	public static bool train;
	public static bool water;
	public static bool ski;
	// public static bool isTrainUnlocked = false;
	// public static bool isWaterUnlocked = false;
	// public static bool isAirUnlocked = false;
	// public static bool isSkiUnlocked = false;
	public static bool isLoaded;
	void Start () {
		finalScore = 0;
		air = false;
		road = false;
		train = false;
		water = false;
		ski = false;
		// isTrainUnlocked = false;
		// isAirUnlocked = false;
		// isWaterUnlocked = false;
		// isSkiUnlocked = false;
		//isLoaded = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Player{
	public int score {get;set;}
	public int highScore{get;set;}
	public int coins{get;set;}
	public bool isAir {get;set;}
	public bool isRoad {get;set;}
	public bool isTrain {get;set;}
	public bool isWater{get;set;}
	public bool isSki {get;set;}
	public bool airUnlocked {get;set;}
	public bool trainUnlocked {get;set;}
	public bool waterUnlocked{get;set;}
	public bool skiUnlocked {get;set;}
	public bool isLoaded {get;set;}
}

public class PlayersData{
	public List<Player> Players;

	public PlayersData(){
		Players = new List<Player>();
	}
}
