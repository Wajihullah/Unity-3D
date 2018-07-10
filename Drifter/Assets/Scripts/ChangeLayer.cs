using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour {

	// Use this for initialization
	Renderer renderer;
	void Start () {
		this.renderer.sortingLayerName = "Background";
		this.renderer.sortingOrder = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
