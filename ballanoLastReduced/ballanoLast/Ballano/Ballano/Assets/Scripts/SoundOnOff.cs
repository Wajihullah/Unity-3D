using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundOnOff : MonoBehaviour {
	public AudioSource audio;
	public Image x;
	public Image y;
	public Image z;
	public int i=0;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		y = GetComponent<Image> ();
		DontDestroyOnLoad ();
	}
	void DontDestroyOnLoad()
	{
		
	}
	public void soundoff()
	{
		//audio.mute = !audio.mute;
		//audio.mute=true;
		if (i == 0) {
			i = 1;
			y.sprite = x.sprite;
		} 
		else if (i == 1) {
			i = 0;
			y.sprite = z.sprite;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
