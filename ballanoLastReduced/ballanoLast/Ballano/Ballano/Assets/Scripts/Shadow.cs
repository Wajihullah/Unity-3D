using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {
	
	// Use this for initialization
	public SpriteRenderer shadow;
	public SpriteRenderer caster;
	public Vector2 vec = new Vector2 (-0, -0);
	public Transform trShadow;
	public Transform trCaster;
	public Color col;
	public Material mat;
	public Sprite sprite;
	public int i=0;
	void Start () {
		trCaster = this.transform;
		trShadow = new GameObject ().transform;
		trShadow.parent = trCaster;
		trShadow.gameObject.name="shadow";
		trShadow.localRotation = Quaternion.identity;
		caster = this.GetComponent<SpriteRenderer> ();
		trShadow.gameObject.AddComponent<SpriteRenderer> ();
		shadow = trShadow.gameObject.GetComponent<SpriteRenderer> ();
		shadow.sortingLayerName = caster.sortingLayerName;
		shadow.sortingOrder = caster.sortingOrder-2;
		shadow.color = col;
		shadow.material = mat;


	}
	void Update()
	{
		i++;
		if (i == 4) {
			caster.transform.eulerAngles = new Vector3 (caster.transform.eulerAngles.x, caster.transform.eulerAngles.y, caster.transform.eulerAngles.z - 1);
			i = 0;
		}
	}
	// Update is called once per frame
	void LateUpdate()
	{
		trShadow.position = new Vector2 (trCaster.position.x,trCaster.position.y+0.4f);
		shadow.sprite = sprite; 
		trShadow.localScale = new Vector3 (1.25f,6.06f,-4.5f);

	}
}
