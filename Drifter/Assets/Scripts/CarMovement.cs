using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using Newtonsoft.Json;
class People{
	public string Name;
	public int Age;
}

public class CarMovement : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	public float speed=4f;
	public float maxSpeed = 8f;
	public GameObject restartButton;
	public Text textScore;
	public Text myHighScore;
	PlayersData playersData;
	public GameObject myText;
	int tempScore;
	public Scorer scoreScript;
	Vector3 vel;
	private List<People> Peopleee;
	private float torqueForce = -1f;

	float angle;
	Vector3 mousePositionInWorld;
	Rigidbody2D rb;
	float carTempSpeed;
	Player player;
	public Text coinText;
	public GameObject deathEffect;
	//public GameObject hook;
	//float startRotationOffset = 30;
	void Start () {
		
		//peed = 1f;
		rb = GetComponent<Rigidbody2D>();
		vel = new Vector3(0,0,speed);
		angle = 0;
		Peopleee = new List<People>();
		Peopleee.Add(new People{Name = "Faraz",Age=22});
		Peopleee.Add(new People{Name = "Anamta",Age=25});
		List<string> names = Peopleee.Where(x=>x.Age > 23).Select(x=>x.Name).ToList();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		
		//transform.Translate(transform.up*Time.deltaTime*speed);
		//rb.velocity = Vector2.ClampMagnitude(rb.velocity,maxSpeed);
		if(rb!=null){
			rb.AddForce(transform.up*speed,ForceMode2D.Impulse);
		}
		
		
		//rb.AddTorque(Input.GetAxis("Horizontal")*torqueForce,ForceMode2D.Impulse);
		mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//angle = (Mathf.Atan2(mousePositionInWorld.y- transform.position.y,mousePositionInWorld.x-transform.position.x)*Mathf.Rad2Deg);
		// if(Input.GetMouseButton(0)){
		// //transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,angle),speed);
		
		// transform.rotation = Quaternion.AngleAxis(2.0f*angle--,Vector3.forward);
		// speed = 0f;
		// }
		// else if(Input.GetMouseButton(1)){
		// //transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,angle),speed);
		
		// transform.rotation = Quaternion.AngleAxis(2.0f*angle++,Vector3.forward);
		// speed = 0f;
		// }
		// else{
		// 	speed = 6f;
		// }
		
				
	}
	void OnCollisionEnter2D(Collision2D collision){
		playersData = new PlayersData();
		if(FinalScore.finalScore>GameState.playerHigh){
			tempScore = FinalScore.finalScore;
		}
		else{
			tempScore = GameState.playerHigh;
		}

		player = new Player{
			score = FinalScore.finalScore,
			isAir = FinalScore.air,
			isRoad = FinalScore.road,
			isTrain = FinalScore.train,
			isWater = FinalScore.water,
			isSki = FinalScore.ski,
			highScore = tempScore,
			coins = GameState.playerCoins,
			trainUnlocked = GameState.isTrainUnlocked,
			airUnlocked = GameState.isAirUnlocked,
			waterUnlocked = GameState.isWaterUnlocked,
			skiUnlocked = GameState.isSkiUnlocked,
			isLoaded = true
		};
		
		
		playersData.Players.Add(player);
		ResourceHelper.SaveToPersistentData("gamestate.json",playersData);
		this.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
		restartButton = FindInActiveObjectByTag("Restart");
		restartButton.SetActive(true);
		//scoreScript = myText.GetComponent<Scorer>();
		//print(FinalScore.finalScore);
		textScore.text = FinalScore.finalScore.ToString();
		myHighScore.text = player.highScore.ToString();
		if(FinalScore.road||FinalScore.water||FinalScore.train){
			deathEffect.SetActive(true);
		}
		//deathEffect.SetActive(true);
		
		Destroy(rb);
		
		// speed = 0f;
		// this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
	}

	void OnTriggerEnter2D(Collider2D col){
		//Debug.Log("Triggered "+col.gameObject.name);
		
		if(col.gameObject.tag == "Collectible"){
			GameState.playerCoins = GameState.playerCoins + 2;
			coinText.text = GameState.playerCoins.ToString();
			Destroy(col.gameObject);
		}
		if(col.gameObject.tag == "Boost"){
			carTempSpeed = speed;
			speed = speed + 2;
			// if(rb!=null){
			// 	rb.AddForce(transform)
			// }
		}
		if(col.gameObject.tag == "BoostEnd"){
			speed  = carTempSpeed;
		}
		else{
			ToggleJoint tj = col.gameObject.transform.GetChild(0).GetComponent<ToggleJoint>();
			tj.enabled = true;
		}
	}

	GameObject FindInActiveObjectByTag(string tag)
{

    Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
    for (int i = 0; i < objs.Length; i++)
    {
        if (objs[i].hideFlags == HideFlags.None)
        {
            if (objs[i].CompareTag(tag))
            {
                return objs[i].gameObject;
            }
        }
    }
    return null;
}
}
