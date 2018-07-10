using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeed : MonoBehaviour {

	// Use this for initialization
	public float maxVelocity=10f;
	public Rigidbody2D rigidbody1;
	public float force=100;
	public float speed=10;
	void Start () {
		rigidbody1 = this.GetComponent<Rigidbody2D> ();
		rigidbody1.velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody.velocity = Vector2.ClampMagnitude (rigidbody.velocity.magnitude,maxVelocity);
		//rigidbody1.AddForce(Vector2.up*force);
		if (rigidbody1.velocity.magnitude > maxVelocity) 
		{
			rigidbody1.velocity = rigidbody1.velocity * maxVelocity;	
		}
	}
}
