using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Retry : MonoBehaviour {

	// Use this for initialization
	public static string PreviousScene = "";
	void Start () {
		DontDestroyOnLoad ();	
	}
	void DontDestroyOnLoad()
	{

	}
	void OnDestroy()
	{
		PreviousScene = SceneManager.GetActiveScene().name;
	}
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene(string sceneName)
	{
		PreviousScene = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(sceneName);
	}
}
