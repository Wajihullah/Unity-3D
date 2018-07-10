using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour {
	public Rigidbody2D rigid;
	// Use this for initialization
	public int t;
	public Vector3 random;
	public int k=0;
	Vector2 movement;
	void Start () {
		t = 1;

	}

	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D col)
	{
		//random = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));

		//t *= -1;
		movement= new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));

	}
	void Update () {
		//rigid.velocity = new Vector3 (k, t, 0);

	}
	void FixedUpdate()
	{
		if (k <= 200) {
			rigid.AddForce (movement * t);
			k++;
		}
	}
}
