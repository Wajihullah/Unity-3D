using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class discMove : MonoBehaviour {

    // Use this for initialization

	public int c=0;
	public int d=0;
	public float accelerationTime = 0f;
    public float maxSpeed = 500f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;
    private Vector3 randomDirection;
	public GameObject hand;
    public float force = 20.0f;
	public GameObject canvas;
	public Camera camera;
	public GameObject canvas1;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "GameObject (2)") {
			canvas1.SetActive(true);

			Destroy (this.gameObject);


			//UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
	}
	private void OnCollisionEnter2D(Collision2D col)
    {
        //randomDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));

        //Drag is how fast object slowing down 
        //rb.drag = 0;

        //ForceMode.VelocityChange will ignore mass of object and apply velocity instantly
        //rb.AddForce(randomDirection * force, ForceMode2D.Force);
		if (col.gameObject.name == "1 (1)" || col.gameObject.name == "1 (2)" || col.gameObject.name == "1 (3)" || col.gameObject.name == "1 (4)" || col.gameObject.name == "1 (5)" || col.gameObject.name == "1 (6)" || col.gameObject.name == "1 (7)") {
			
			gameObject.transform.GetChild (0).gameObject.SetActive (true);
		} else if (col.gameObject.name == "spike") {
			//gameObject.transform.GetChild (1).gameObject.SetActive (true);

			hand.SetActive (true);
			hand.transform.parent = null;

			camera.GetComponent<CreateLine> ().enabled = false;
			canvas.SetActive(true);

			Destroy (this.gameObject);

		} 
		else if (col.gameObject.name == "end" || col.gameObject.name == "end1" || col.gameObject.name == "end2" || col.gameObject.name == "end3") {
			canvas1.SetActive(true);

			Destroy (this.gameObject);


			//UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
    }
    // Update is called once per frame
    void Update () {
		if (gameObject.transform.GetChild (0).gameObject.activeSelf == true) {
			c++;
			if (c == 40) {
				c = 0;
				gameObject.transform.GetChild (0).gameObject.SetActive (false);
			}
		}
		//transform.Translate (Vector3.forward * Time.deltaTime * maxSpeed);
				//Destroy (this.gameObject);					
	
				
				

        /*timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }*/
    }
    void FixedUpdate()
    {
        //rb.AddForce(movement * maxSpeed);
    }
}
