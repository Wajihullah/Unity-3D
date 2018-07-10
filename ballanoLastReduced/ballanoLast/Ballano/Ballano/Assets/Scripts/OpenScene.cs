using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenScene : MonoBehaviour {
	
	public void ChangeScene(int gotoScene)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene (gotoScene);

	}
}
