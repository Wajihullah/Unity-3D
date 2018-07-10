using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleJoint : MonoBehaviour {


	FixedJoint2D fixedJoint2D;
	public Rigidbody2D car;
	public GameObject carObj;
	Vector3 carV;
	public Transform targetTransform;
	public float maxSpeed = 4.5f;
	private LineRenderer lineRenderer;
	Vector2 v;
	public GameObject nextroad;
	public GameObject leftSkid;
	public GameObject rightSkid;
	public float speed = 0.1f;
	private float dist;
	private float lineDrawSpeed;

	int turn;
	void Start () {
		
		car = GameObject.FindGameObjectWithTag("Car").GetComponent<Rigidbody2D>();
		carObj = GameObject.FindGameObjectWithTag("Car");
		targetTransform = GameObject.FindGameObjectWithTag("Car").GetComponent<Transform>();
		fixedJoint2D = this.gameObject.GetComponent<FixedJoint2D>();
		fixedJoint2D.connectedBody = car;
		fixedJoint2D.enabled = false;
		leftSkid = FindInActiveObjectByTag("LeftSkid");
		rightSkid = FindInActiveObjectByTag("Skid");
		//car.freezeRotation = false;
	}
	
	
	void Update () {
		//car.velocity = Vector3.ClampMagnitude(car.velocity,maxSpeed);
		if(Input.GetMouseButton(0) && car!=null){
		
			v = car.velocity;
			//car.velocity = Vector2.zero;
			//car.velocity = v;
			leftSkid.SetActive(true);
			rightSkid.SetActive(true);
			fixedJoint2D.enabled = true;
			lineRenderer = this.GetComponent<LineRenderer>();
			lineRenderer.SetPosition(0,this.transform.position);
			lineRenderer.startWidth = 0.2f;
			lineRenderer.endWidth = 0.2f;
			dist = Vector3.Distance(this.transform.position,carObj.transform.position);
			float x = Mathf.Lerp(0,dist,1f);
			Vector3 pointA = this.transform.position;
			Vector3 pointB = carObj.transform.position;
			Vector3 pointAlongLine = x*Vector3.Normalize(pointB-pointA)+pointA;
			lineRenderer.SetPosition(1,pointAlongLine);
		

		}
		if(Input.GetMouseButtonUp(0) && car!=null){
			// Vector3 direction = targetTransform.position - carObj.transform.position;
			// print(direction);
			fixedJoint2D.enabled = false;
			leftSkid.SetActive(false);
			rightSkid.SetActive(false);
			//car.velocity = Vector3.ClampMagnitude(car.velocity,0);
			//car.velocity = Vector3.zero;
			car.angularVelocity = 0;
			transform.rotation = Quaternion.identity;
			//Debug.DrawLine(transform.position,targetTransform.position);
			//Debug.Log("Line drawn");
			ToggleJoint tj = this.GetComponent<ToggleJoint>();
			if(tj.enabled == true){
				tj.enabled = false;
			}
			lineRenderer.enabled = false;
			float step = speed * Time.deltaTime;
			try{
        	car.transform.position = Vector3.RotateTowards(car.transform.position, targetTransform.transform.position, step,0);
			}catch(System.Exception){}
			//car.angularVelocity -= 0.5f;
			//car.angularVelocity += 0.5f;
				// Vector3 vectorToTarget = transform.GetChild(0).position - carObj.transform.position;
 				// float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
 				// Quaternion q = Quaternion.AngleAxis(angle, Vector3.right);
 				// carObj.transform.rotation = Quaternion.Slerp(carObj.transform.rotation, q, Time.deltaTime * speed);
			// Vector3 diff = transform.GetChild(0).position - carObj.transform.position;
			// diff.Normalize();
			//float rot_z = Mathf.Atan2(diff.y,diff.x) * Mathf.Rad2Deg;
			// float rot_z = Mathf.Lerp(carObj.transform.rotation.z,transform.GetChild(0).rotation.z,5.0f);
			
			// carObj.transform.rotation = Quaternion.Euler(0f,0f,turn);
			//car.inertia = 3.0f;
			// Debug.Log("Up");
			//carObj.transform.rotation = targetTransform.rotation;
			// Vector2 relativePos = transform.GetChild(0).position - carObj.transform.position;
			// Quaternion rotation = Quaternion.LookRotation(relativePos);
			// carObj.transform.rotation = rotation;
			// carObj.transform.Rotate(0,0,0);
			// carObj.transform.position = transform.GetChild(0).position + transform.GetChild(0).TransformDirection(new Vector3(0,0,0));
			// // Debug.Log(car.transform.position);
			// // Debug.Log(targetTransform.position);
			// Vector3 moveDir = (transform.GetChild(0).position - carObj.transform.position).normalized;
			// carObj.transform.position += moveDir*3.0f*Time.deltaTime;
		}
			// if(Input.GetMouseButtonUp(0)){
			
				
			// 	//car.AddTorque(20);
			// 	// car.transform.up = targetTransform.position;
			// 	Debug.Log ("Up");
			// 	// car.velocity = Vector2.zero;
			// 	// car.velocity = v;
			// 	//car.transform.LookAt(targetTransform);
				
			// 	//car.transform.position = targetTransform.position;
			// 	// Vector3 vectorToTarget = targetTransform.position - car.transform.position;
 			// 	// float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
 			// 	// Quaternion q = Quaternion.AngleAxis(angle, Vector3.right);
 			// 	// car.transform.rotation = Quaternion.Slerp(car.transform.rotation, q, Time.deltaTime * speed);
			// 	//car.transform.rotation = Quaternion.Euler (0, 0, -90);
			// 	//car.transform.rotation = Quaternion.RotateTowards (car.transform.rotation,Quaternion.AngleAxis(-90,Vector3.forward),10*2f*Time.deltaTime);
			// 	//car.freezeRotation = true;
			// 		//					Quaternion.Lerp (car.transform.rotation,Quaternion.Euler(0,0,-90), Time.time*speed);
			// }
			// else{
				
			// 	//fixedJoint2D.enabled = false;
			// }
		

	// if(RotationFreeze()){
	// 	if(Time.time>3.0f){
	// 	 		car.freezeRotation = false;
	// 	}
	// }
	if(car!=null){
		carV = car.velocity;
	}
		
}

	//public bool RotationFreeze(){
	//	return car.freezeRotation;
	//}
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
