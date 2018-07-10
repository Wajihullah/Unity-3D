using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class SampleFile : MonoBehaviour {

	// Use this for initialization
	Player player;
	void Start () {
		player = new Player {
			name = "Zia",
			age = 19
		};

		ResourceHelper.SaveToPersistentData ("player.json", player);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


public class Player{
	public string name { get; set;}
	public int age { get; set; }
}