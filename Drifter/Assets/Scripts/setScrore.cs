using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class setScrore : MonoBehaviour {

	public GameObject [] score;

	
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col){
		print("SCOREE TRIGGERED...");
		for(int i = 0; i< score.Length; i++){
		
score[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = (FinalScore.finalScore+i+1).ToString();
		print(score[i].transform.GetChild(0).gameObject.GetComponent<Text>().text);
		}
	}
}
