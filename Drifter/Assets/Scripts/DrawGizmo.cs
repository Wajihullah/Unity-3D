using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	public Transform source;
	public LineRenderer lineRenderer;
	private float dist;
	private float counter;
	public float lineDrawSpeed;
	void Start () {
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.SetPosition(0,source.position);
		lineRenderer.startWidth = 0.2f;
		lineRenderer.endWidth = 0.2f;
		dist = Vector3.Distance(source.position,target.position);
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.DrawLine(transform.position,target.position);
		// lineRenderer.SetPosition(0,transform.position-target.position);
		// lineRenderer.SetPosition(1,target.position-transform.position);
		
			counter+=.1f/lineDrawSpeed;
			float x = Mathf.Lerp(0,dist,1f);
			Vector3 pointA = source.position;
			Vector3 pointB = target.position;
			Vector3 pointAlongLine = x*Vector3.Normalize(pointB-pointA)+pointA;
			lineRenderer.SetPosition(1,pointAlongLine);
		
		
	}
	// private void OnDrawGizmos(){
	// 	Gizmos.color = Color.red;
	// 	Gizmos.DrawLine(transform.position,target.position);
		
	// }
}
