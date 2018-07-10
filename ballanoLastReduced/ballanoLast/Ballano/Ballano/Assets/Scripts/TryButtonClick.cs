using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TryButtonClick : MonoBehaviour {
	public Button bt;
	// Use this for initialization
	public Button bt1; 

	void Start () {
		bt1 = bt.GetComponent<Button> ();
		bt1.onClick.AddListener (Task);
	}
	void Task()
	{
		if (bt1.image.sprite.name != "locked level") {
			if (bt1.name == "level1"&& bt1.image.sprite.name=="level 1") {
				SceneManager.LoadScene("Main");
			}
			else if (bt1.name == "level2"&& bt1.image.sprite.name=="level 2") {
				SceneManager.LoadScene("Level2");
			}
			else if (bt1.name == "level3"&& bt1.image.sprite.name=="level 3") {
				SceneManager.LoadScene("Level3");
			}
			else if (bt1.name == "level4"&& bt1.image.sprite.name=="level 4") {
				SceneManager.LoadScene("Level4");
			}
			else if (bt1.name == "level5"&& bt1.image.sprite.name=="level 5") {
				SceneManager.LoadScene("Level5");
			}
			else if (bt1.name == "level6"&& bt1.image.sprite.name=="level 6") {
				SceneManager.LoadScene("Level6");
			}
			else if (bt1.name == "level7"&& bt1.image.sprite.name=="level 7") {
				SceneManager.LoadScene("Level7");
			}
			else if (bt1.name == "level8"&& bt1.image.sprite.name=="level 8") {
				SceneManager.LoadScene("Level8");
			}
			else if (bt1.name == "level9"&& bt1.image.sprite.name=="level 9") {
				SceneManager.LoadScene("Level9");
			}
			else if (bt1.name == "level10"&& bt1.image.sprite.name=="level 10") {
				SceneManager.LoadScene("Level10");
			}
			else if (bt1.name == "level11"&& bt1.image.sprite.name=="leevl 11") {
				Debug.Log ("working");
				SceneManager.LoadScene("Level11");

			}
			else if (bt1.name == "level12"&& bt1.image.sprite.name=="level 12") {
				SceneManager.LoadScene("Level12");
			}

		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
