using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class SampleRead : MonoBehaviour {

	// Use this for initialization
	Player player;
	void Start () {
		string json = ResourceHelper.ReadFromPersistentData ("player.json");
		player = ResourceHelper.DecodeObject<Player> (json);
		print (player.name);
		print (player.age);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
