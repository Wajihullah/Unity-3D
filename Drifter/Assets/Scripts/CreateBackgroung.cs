using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBackgroung : MonoBehaviour {

	// Use this for initialization
	public GameObject back;
	
	float URx;
	float URy;
	float ULx;
	float ULy;
	float DRx;
	float DRy;
	float DLx;
	float DLy;

	void Start () {
		for(int i = 0; i< 10;i++){
			for(int j = 0; j< 15;j++){
 					URx = 10.8f*j;
					URy = 19.2f*i;
					Vector3 URpos = new Vector3(URx, URy, 0);
                GameObject.Instantiate(back, URpos, Quaternion.identity);
				
					ULx = -10.8f*j;
					ULy = 19.2f*i;
					Vector3 ULpos = new Vector3(ULx, ULy, 0);
                GameObject.Instantiate(back, ULpos, Quaternion.identity);
			
					URx = 10.8f*j;
					URy = -19.2f*i;
					Vector3 DRpos = new Vector3(URx, URy, 0);
                GameObject.Instantiate(back, DRpos, Quaternion.identity);
				
					URx = -10.8f*j;
					URy = -19.2f*i;
					Vector3 DLpos = new Vector3(URx, URy, 0);
                GameObject.Instantiate(back, DLpos, Quaternion.identity);
					}
		}
	}
	
}
