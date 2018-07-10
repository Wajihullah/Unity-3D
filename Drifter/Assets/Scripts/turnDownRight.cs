using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnDownRight : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col){
		//print("Right Triggered");
		
	 col.gameObject.transform.rotation = Quaternion.Euler(0f,0f,270f);
				
		
	}
}
