using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
public class ReadStars : MonoBehaviour {

	// Use this for initialization
	public static level1 Level1;
	public level2 Level2;
	public level3 Level3;
	public level4 Level4;
	public level5 Level5;
	public level6 Level6;
	public level7 Level7;
	public level8 Level8;
	public level9 Level9;
	public level10 Level10;
	public level11 Level11;
	public level12 Level12;
	public level13 Level13;
	public level14 Level14;
	public level15 Level15;
	public level16 Level16;
	public level17 Level17;
	public level18 Level18;
	public level19 Level19;
	public level20 Level20;
	public level21 Level21;
	public level22 Level22;
	public level23 Level23;
	public level24 Level24;
	public level25 Level25;
	public level26 Level26;
	public level27 Level27;
	public level28 Level28;
	public level29 Level29;
	public level30 Level30;
	public level31 Level31;
	public level32 Level32;
	public level33 Level33;
	public level34 Level34;
	public level35 Level35;
	public level36 Level36;
	public level37 Level37;
	public level38 Level38;
	public level39 Level39;
	public level40 Level40;
	public level41 Level41;
	public level42 Level42;
	public level43 Level43;
	public level44 Level44;
	public level45 Level45;
	public level46 Level46;
	public level47 Level47;
	public level48 Level48;
	public level49 Level49;
	public level50 Level50;
	public level51 Level51;
	public level52 Level52;
	public level53 Level53;
	public level54 Level54;
	public level55 Level55;
	public level56 Level56;
	public level57 Level57;
	public level58 Level58;
	public level59 Level59;
	public level60 Level60;
	public GameObject l1;
	public GameObject l2;
	public GameObject l3;
	public GameObject l4;
	public GameObject l5;
	public GameObject l6;
	public GameObject l7;
	public GameObject l8;
	public GameObject l9;
	public GameObject l10;
	public GameObject l11;
	public GameObject l12;
	public GameObject l13;
	public GameObject l14;
	public GameObject l15;
	public GameObject l16;
	public GameObject l17;
	public GameObject l18;
	public GameObject l19;
	public GameObject l20;
	public GameObject l21;
	public GameObject l22;
	public GameObject l23;
	public GameObject l24;
	public GameObject l25;
	public GameObject l26;
	public GameObject l27;
	public GameObject l28;
	public GameObject l29;
	public GameObject l30;
	public GameObject l31;
	public GameObject l32;
	public GameObject l33;
	public GameObject l34;
	public GameObject l35;
	public GameObject l36;
	public GameObject l37;
	public GameObject l38;
	public GameObject l39;
	public GameObject l40;
	public GameObject l41;
	public GameObject l42;
	public GameObject l43;
	public GameObject l44;
	public GameObject l45;
	public GameObject l46;
	public GameObject l47;
	public GameObject l48;
	public GameObject l49;
	public GameObject l50;
	public GameObject l51;
	public GameObject l52;
	public GameObject l53;
	public GameObject l54;
	public GameObject l55;
	public GameObject l56;
	public GameObject l57;
	public GameObject l58;
	public GameObject l59;
	public GameObject l60;
	public Sprite Star1;
	public Sprite Star2;
	public Sprite Star3;

	public Image le1im1;
	public Image le1im2;
	public Image le1im3;
	public Image le2im1;
	public Image le2im2;
	public Image le2im3;
	public Image le3im1;
	public Image le3im2;
	public Image le3im3;
	public Image le4im1;
	public Image le4im2;
	public Image le4im3;
	public Image le5im1;
	public Image le5im2;
	public Image le5im3;
	public Image le6im1;
	public Image le6im2;
	public Image le6im3;
	public Image le7im1;
	public Image le7im2;
	public Image le7im3;
	public Image le8im1;
	public Image le8im2;
	public Image le8im3;
	public Image le9im1;
	public Image le9im2;
	public Image le9im3;
	public Image le10im1;
	public Image le10im2;
	public Image le10im3;
	public Image le11im1;
	public Image le11im2;
	public Image le11im3;
	public Image le12im1;
	public Image le12im2;
	public Image le12im3;
	public Image l1img;
	public Image l2img;
	public Image l3img;
	public Image l4img;
	public Image l5img;
	public Image l6img;
	public Image l7img;
	public Image l8img;
	public Image l9img;
	public Image l10img;
	public Image l11img;
	public Image l12img;
	public Image l13img;
	public Image l14img;
	public Image l15img;
	public Image l16img;
	public Image l17img;
	public Image l18img;
	public Image l19img;
	public Image l20img;
	public Image l21img;
	public Image l22img;
	public Image l23img;
	public Image l24img;
	public Image l25img;
	public Image l26img;
	public Image l27img;
	public Image l28img;
	public Image l29img;
	public Image l30img;
	public Image l31img;
	public Image l32img;
	public Image l33img;
	public Image l34img;
	public Image l35img;
	public Image l36img;
	public Image l37img;
	public Image l38img;
	public Image l39img;
	public Image l40img;
	public Image l41img;
	public Image l42img;
	public Image l43img;
	public Image l44img;
	public Image l45img;
	public Image l46img;
	public Image l47img;
	public Image l48img;
	public Image l49img;
	public Image l50img;
	public Image l51img;
	public Image l52img;
	public Image l53img;
	public Image l54img;
	public Image l55img;
	public Image l56img;
	public Image l57img;
	public Image l58img;
	public Image l59img;
	public Image l60img;
	public Sprite sp1;
	public Sprite sp2;
	public Sprite sp3;
	public Sprite sp4;
	public Sprite sp5;
	public Sprite sp6;
	public Sprite sp7;
	public Sprite sp8;
	public Sprite sp9;
	public Sprite sp10;
	public Sprite sp11;
	public Sprite sp12;
	public GameObject l1bimg;
	public GameObject l2bimg;
	public GameObject l3bimg;
	public GameObject l4bimg;
	public GameObject l5bimg;
	public GameObject l6bimg;
	public GameObject l7bimg;
	public GameObject l8bimg;
	public GameObject l9bimg;
	public GameObject l10bimg;
	public GameObject l11bimg;
	public GameObject l12bimg;
	void Start () {
		

		string json;
		//ResourceHelper.SaveToPersistentData ("level3.json", "");
		if(ResourceHelper.ExistsInPersistentData("level1.json"))
			{
				json = ResourceHelper.ReadFromPersistentData ("level1.json");
				Level1 = ResourceHelper.DecodeObject<level1> (json);
			}
		if (ResourceHelper.ExistsInPersistentData ("level2.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level2.json");
			Level2 = ResourceHelper.DecodeObject<level2> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level3.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level3.json");
			Level3 = ResourceHelper.DecodeObject<level3> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level4.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level4.json");
			Level4 = ResourceHelper.DecodeObject<level4> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level5.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level5.json");
			Level5 = ResourceHelper.DecodeObject<level5> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level6.json")) {
			json = ResourceHelper.ReadFromPersistentData ("leve6.json");
			Level6 = ResourceHelper.DecodeObject<level6> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level7.json");
			Level7 = ResourceHelper.DecodeObject<level7> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level8.json");
			Level8 = ResourceHelper.DecodeObject<level8> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level9.json");
			Level9 = ResourceHelper.DecodeObject<level9> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level10.json");
			Level10 = ResourceHelper.DecodeObject<level10> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level11.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level11.json");
			Level11 = ResourceHelper.DecodeObject<level11> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level12.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level12.json");
			Level12 = ResourceHelper.DecodeObject<level12> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level13.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level13.json");
			Level13 = ResourceHelper.DecodeObject<level13> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level14.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level14.json");
			Level14 = ResourceHelper.DecodeObject<level14> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level15.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level15.json");
			Level15 = ResourceHelper.DecodeObject<level15> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level16.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level16.json");
			Level16 = ResourceHelper.DecodeObject<level16> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level17.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level17.json");
			Level17 = ResourceHelper.DecodeObject<level17> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level18.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level18.json");
			Level18 = ResourceHelper.DecodeObject<level18> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level19.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level19.json");
			Level19 = ResourceHelper.DecodeObject<level19> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level20.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level20.json");
			Level20 = ResourceHelper.DecodeObject<level20> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level21.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level21.json");
			Level21 = ResourceHelper.DecodeObject<level21> (json);
		}
		/*json = ResourceHelper.ReadFromPersistentData ("level22.json");
		Level22 = ResourceHelper.DecodeObject<level22> (json);
		json = ResourceHelper.ReadFromPersistentData ("level23.json");
		Level23 = ResourceHelper.DecodeObject<level23> (json);
		json = ResourceHelper.ReadFromPersistentData ("level24.json");
		Level24 = ResourceHelper.DecodeObject<level24> (json);
		json = ResourceHelper.ReadFromPersistentData ("level25.json");
		Level25 = ResourceHelper.DecodeObject<level25> (json);
		json = ResourceHelper.ReadFromPersistentData ("level26.json");
		Level26 = ResourceHelper.DecodeObject<level26> (json);
		json = ResourceHelper.ReadFromPersistentData ("level27.json");
		Level27 = ResourceHelper.DecodeObject<level27> (json);
		json = ResourceHelper.ReadFromPersistentData ("level28.json");
		Level28 = ResourceHelper.DecodeObject<level28> (json);
		json = ResourceHelper.ReadFromPersistentData ("level29.json");
		Level29 = ResourceHelper.DecodeObject<level29> (json);
		json = ResourceHelper.ReadFromPersistentData ("level30.json");
		Level30 = ResourceHelper.DecodeObject<level30> (json);
		json = ResourceHelper.ReadFromPersistentData ("level31.json");
		Level31 = ResourceHelper.DecodeObject<level31> (json);
		json = ResourceHelper.ReadFromPersistentData ("level32.json");
		Level32 = ResourceHelper.DecodeObject<level32> (json);
		json = ResourceHelper.ReadFromPersistentData ("level33.json");
		Level33 = ResourceHelper.DecodeObject<level33> (json);
		json = ResourceHelper.ReadFromPersistentData ("level34.json");
		Level34 = ResourceHelper.DecodeObject<level34> (json);
		json = ResourceHelper.ReadFromPersistentData ("level35.json");
		Level35 = ResourceHelper.DecodeObject<level35> (json);
		json = ResourceHelper.ReadFromPersistentData ("level36.json");
		Level36 = ResourceHelper.DecodeObject<level36> (json);
		json = ResourceHelper.ReadFromPersistentData ("level37.json");
		Level37 = ResourceHelper.DecodeObject<level37> (json);
		json = ResourceHelper.ReadFromPersistentData ("level38.json");
		Level38 = ResourceHelper.DecodeObject<level38> (json);
		json = ResourceHelper.ReadFromPersistentData ("level39.json");
		Level39 = ResourceHelper.DecodeObject<level39> (json);
		json = ResourceHelper.ReadFromPersistentData ("level40.json");
		Level40 = ResourceHelper.DecodeObject<level40> (json);
		json = ResourceHelper.ReadFromPersistentData ("level41.json");
		Level41 = ResourceHelper.DecodeObject<level41> (json);
		json = ResourceHelper.ReadFromPersistentData ("level42.json");
		Level42 = ResourceHelper.DecodeObject<level42> (json);
		json = ResourceHelper.ReadFromPersistentData ("level43.json");
		Level43 = ResourceHelper.DecodeObject<level43> (json);
		json = ResourceHelper.ReadFromPersistentData ("level44.json");
		Level44 = ResourceHelper.DecodeObject<level44> (json);
		json = ResourceHelper.ReadFromPersistentData ("level45.json");
		Level45 = ResourceHelper.DecodeObject<level45> (json);
		json = ResourceHelper.ReadFromPersistentData ("level46.json");
		Level46 = ResourceHelper.DecodeObject<level46> (json);
		json = ResourceHelper.ReadFromPersistentData ("level47.json");
		Level47 = ResourceHelper.DecodeObject<level47> (json);
		json = ResourceHelper.ReadFromPersistentData ("level48.json");
		Level48 = ResourceHelper.DecodeObject<level48> (json);
		json = ResourceHelper.ReadFromPersistentData ("level49.json");
		Level49 = ResourceHelper.DecodeObject<level49> (json);
		json = ResourceHelper.ReadFromPersistentData ("level50.json");
		Level50 = ResourceHelper.DecodeObject<level50> (json);
		json = ResourceHelper.ReadFromPersistentData ("level51.json");
		Level51 = ResourceHelper.DecodeObject<level51> (json);
		json = ResourceHelper.ReadFromPersistentData ("level52.json");
		Level52 = ResourceHelper.DecodeObject<level52> (json);
		json = ResourceHelper.ReadFromPersistentData ("level53.json");
		Level53 = ResourceHelper.DecodeObject<level53> (json);
		json = ResourceHelper.ReadFromPersistentData ("level54.json");
		Level54 = ResourceHelper.DecodeObject<level54> (json);
		json = ResourceHelper.ReadFromPersistentData ("level55.json");
		Level55 = ResourceHelper.DecodeObject<level55> (json);
		json = ResourceHelper.ReadFromPersistentData ("level56.json");
		Level56 = ResourceHelper.DecodeObject<level56> (json);
		json = ResourceHelper.ReadFromPersistentData ("level57.json");
		Level57 = ResourceHelper.DecodeObject<level57> (json);
		json = ResourceHelper.ReadFromPersistentData ("level58.json");
		Level58 = ResourceHelper.DecodeObject<level58> (json);
		json = ResourceHelper.ReadFromPersistentData ("level59.json");
		Level59 = ResourceHelper.DecodeObject<level59> (json);
		json = ResourceHelper.ReadFromPersistentData ("level60.json");
		Level60 = ResourceHelper.DecodeObject<level60> (json);*/
		print (Level1.completed);
		print (Level1.star);
		if(ResourceHelper.ExistsInPersistentData("level1.json"))
		{
			l1img.sprite = sp1;
			//l1img.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			print ("lol");
			l1.SetActive (true);
			print ("here");
			if (Level1.completed == true) {
				if (Level1.star == 3) {
				
					le1im1.sprite = Star1;
					le1im2.sprite = Star2;
					le1im3.sprite = Star3;
				} else if (Level1.star == 2) {
					print ("1star");
					le1im1.sprite = Star1;
					le1im2.sprite = Star2;
				} else if (Level1.star == 1) {
				
					le1im1.sprite = Star1;
				}
			}
		}
		if(ResourceHelper.ExistsInPersistentData("level2.json"))
		{
			l2img.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			l2img.sprite = sp2;
			print ("lol");
			l2.SetActive (true);
			print ("here");
			if (Level2.completed == true) {
				if (Level2.star == 3) {

					le2im1.sprite = Star1;
					le2im2.sprite = Star2;
					le2im3.sprite = Star3;
				} else if (Level2.star == 2) {
					print ("1star");
					le2im1.sprite = Star1;
					le2im2.sprite = Star2;
				} else if (Level2.star == 1) {

					le2im1.sprite = Star1;
				}
			}
		}
		if(ResourceHelper.ExistsInPersistentData("level3.json"))
		{
			l3img.sprite = sp3;
			print ("lol");
			l3.SetActive (true);
			print ("here");
			if (Level3.completed == true) {
				if (Level3.star == 3) {

					le3im1.sprite = Star1;
					le3im2.sprite = Star2;
					le3im3.sprite = Star3;
				} else if (Level3.star == 2) {
					print ("1star");
					le3im1.sprite = Star1;
					le3im2.sprite = Star2;
				} else if (Level3.star == 1) {

					le3im1.sprite = Star1;
				}
			}
		}
		if(ResourceHelper.ExistsInPersistentData("level4.json"))
		{
			l4img.sprite = sp4;
			print ("lol");
			l4.SetActive (true);
			print ("here");
			if (Level4.completed == true) {
				if (Level4.star == 3) {

					le4im1.sprite = Star1;
					le4im2.sprite = Star2;
					le4im3.sprite = Star3;
				} else if (Level4.star == 2) {
					print ("1star");
					le4im1.sprite = Star1;
					le4im2.sprite = Star2;
				} else if (Level4.star == 1) {

					le4im1.sprite = Star1;
				}
			}
		}
		if(ResourceHelper.ExistsInPersistentData("level5.json"))
		{
			l5img.sprite = sp5;
			print ("lol");
			l5.SetActive (true);
			print ("here");
			if (Level5.completed == true) {
				if (Level5.star == 3) {

					le5im1.sprite = Star1;
					le5im2.sprite = Star2;
					le5im3.sprite = Star3;
				} else if (Level5.star == 2) {
					print ("1star");
					le5im1.sprite = Star1;
					le5im2.sprite = Star2;
				} else if (Level5.star == 1) {

					le5im1.sprite = Star1;
				}
			}
		}
		if(ResourceHelper.ExistsInPersistentData("level6.json"))
		{
			l6img.sprite = sp6;
			print ("lol");
			l6.SetActive (true);
			print ("here");
			if (Level6.completed == true) {
				if (Level6.star == 3) {

					le6im1.sprite = Star1;
					le6im2.sprite = Star2;
					le6im3.sprite = Star3;
				} else if (Level6.star == 2) {
					print ("1star");
					le6im1.sprite = Star1;
					le6im2.sprite = Star2;
				} else if (Level6.star == 1) {

					le6im1.sprite = Star1;
				}
			}
		}
		if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
			l7img.sprite = sp7;
			print ("lol");
			l7.SetActive (true);
			print ("here");
			if (Level7.completed == true) {
				if (Level7.star == 3) {

					le7im1.sprite = Star1;
					le7im2.sprite = Star2;
					le7im3.sprite = Star3;
				} else if (Level7.star == 2) {
					print ("1star");
					le7im1.sprite = Star1;
					le7im2.sprite = Star2;
				} else if (Level7.star == 1) {

					le7im1.sprite = Star1;
				}
			}
		}
		if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
			l8img.sprite = sp8;
			print ("lol");
			l8.SetActive (true);
			print ("here");
			if (Level8.completed == true) {
				if (Level8.star == 3) {

					le8im1.sprite = Star1;
					le8im2.sprite = Star2;
					le8im3.sprite = Star3;
				} else if (Level8.star == 2) {
					print ("1star");
					le8im1.sprite = Star1;
					le8im2.sprite = Star2;
				} else if (Level8.star == 1) {

					le8im1.sprite = Star1;
				}
			}
		}
		if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
			l9img.sprite = sp9;
			print ("lol");
			l9.SetActive (true);
			print ("here");
			if (Level9.completed == true) {
				if (Level9.star == 3) {

					le9im1.sprite = Star1;
					le9im2.sprite = Star2;
					le9im3.sprite = Star3;
				} else if (Level9.star == 2) {
					print ("1star");
					le9im1.sprite = Star1;
					le9im2.sprite = Star2;
				} else if (Level9.star == 1) {

					le9im1.sprite = Star1;
				}
			}
		}
		if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
			l10img.sprite = sp10;
			print ("lol");
			l10.SetActive (true);
			print ("here");
			if (Level10.completed == true) {
				if (Level10.star == 3) {

					le10im1.sprite = Star1;
					le10im2.sprite = Star2;
					le10im3.sprite = Star3;
				} else if (Level10.star == 2) {
					print ("1star");
					le10im1.sprite = Star1;
					le10im2.sprite = Star2;
				} else if (Level10.star == 1) {

					le10im1.sprite = Star1;
				}
			}
		}
		if(ResourceHelper.ExistsInPersistentData("level11.json"))
			{
				l11img.sprite = sp11;
				print ("lol");
				l11.SetActive (true);
				print ("here");
			if (Level11.completed == true) {
				if (Level11.star == 3) {

					le11im1.sprite = Star1;
					le11im2.sprite = Star2;
					le11im3.sprite = Star3;
				} else if (Level11.star == 2) {
					print ("1star");
					le11im1.sprite = Star1;
					le11im2.sprite = Star2;
				} else if (Level11.star == 1) {

					le11im1.sprite = Star1;
				}
			}
			}
		if(ResourceHelper.ExistsInPersistentData("level12.json"))
			{
				l12img.sprite = sp12;
				l12.SetActive (true);

				print ("here");
			if (Level12.completed == true) {
				if (Level12.star == 3) {

					le12im1.sprite = Star1;
					le12im2.sprite = Star2;
					le12im3.sprite = Star3;
				} else if (Level12.star == 2) {
					print ("1star");
					le12im1.sprite = Star1;
					le12im2.sprite = Star2;
				} else if (Level12.star == 1) {

					le12im1.sprite = Star1;
				}
			}
			}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
