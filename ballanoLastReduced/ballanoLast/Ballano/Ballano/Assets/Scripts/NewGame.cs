using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {

	// Use this for initialization
	public firsttime First;
	void Start () {
		if(ResourceHelper.ReadFromPersistentData ("player.json")=="")
		{
			print ("this is it");
		}
		//ResourceHelper.SaveToPersistentData ("level3.json");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public class firsttime
{
	public int x{ get; set;}
}