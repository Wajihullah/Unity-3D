using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scorer : MonoBehaviour {

	// Use this for initialization
	public int score;
	void Start () {
		//score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log("Point");
		this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.white;
		this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = 300;
		// score +=1;
		// print(score);
		FinalScore.finalScore+=1;
	}
}
