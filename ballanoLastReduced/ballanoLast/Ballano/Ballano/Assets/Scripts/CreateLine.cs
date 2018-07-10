using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
public class CreateLine : MonoBehaviour 
{
    private LineRenderer line; // Reference to LineRenderer
    private Vector3 mousePos;    
    private Vector3 startPos;    // Start position of line
    private Vector3 endPos;    // End position of line
	public Color col;
	public Material mat;
	public int i=0;
	public int j=-2;
	public List<LineRenderer> a;
	public Image image;
	public Image image1;
	public Image image2;
	public Sprite sprite;
	public Sprite sprite1;
	public level1 Level1;
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

	void start()
	{
		
		//line.material = mat;

		line.SetColors (col, col);
		a = new List<LineRenderer> ();
	}
    void Update () 
    {
		if (GameObject.Find ("disc") == null) {
			
			if (i <= 2) {
				image.sprite = sprite;
				image1.sprite = sprite;
				image2.sprite = sprite;
				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Main") {
					Level1 = new level1 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level1.json", Level1);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level2") {
					Level2 = new level2 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level2.json", Level2);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level3") {
					Level3 = new level3 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level3.json", Level3);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level4") {
					Level4 = new level4 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level4.json", Level4);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level5") {
					Level5 = new level5 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level5.json", Level5);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level6") {
					Level6 = new level6 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level6.json", Level6);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level7") {
					Level7 = new level7 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level7.json", Level7);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level8") {
					Level8 = new level8 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level8.json", Level8);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level9") {
					Level9 = new level9 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level9.json", Level9);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level10") {
					Level10 = new level10 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level10.json", Level10);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level11") {
					Level11 = new level11 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level11.json", Level11);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level12") {
					Level12 = new level12 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level12.json", Level12);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level13") {
					Level13 = new level13 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level13.json", Level13);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level14") {
					Level14 = new level14 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level14.json", Level14);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level15") {
					Level15 = new level15 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level15.json", Level15);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level16") {
					Level16 = new level16 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level16.json", Level16);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level17") {
					Level17 = new level17 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level17.json", Level17);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level18") {
					Level18 = new level18 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level18.json", Level18);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level19") {
					Level19 = new level19 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level19.json", Level19);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level20") {
					Level20 = new level20 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level20.json", Level20);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level21") {
					Level21 = new level21 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level21.json", Level21);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level22") {
					Level22 = new level22 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level22.json", Level22);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level23") {
					Level23 = new level23 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level23.json", Level23);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level24") {
					Level24 = new level24 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level24.json", Level24);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level25") {
					Level25 = new level25 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level25.json", Level25);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level26") {
					Level26 = new level26 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level26.json", Level26);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level27") {
					Level27 = new level27 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level27.json", Level27);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level28") {
					Level28 = new level28 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level28.json", Level28);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level29") {
					Level29 = new level29 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level29.json", Level29);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level30") {
					Level30 = new level30 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level30.json", Level30);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level31") {
					Level31 = new level31 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level31.json", Level31);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level32") {
					Level32 = new level32 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level32.json", Level32);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level33") {
					Level33 = new level33 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level33.json", Level33);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level34") {
					Level34 = new level34 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level34.json", Level34);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level35") {
					Level35 = new level35 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level35.json", Level35);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level36") {
					Level36 = new level36 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level36.json", Level36);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level37") {
					Level37 = new level37 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level37.json", Level37);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level38") {
					Level38 = new level38 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level38.json", Level38);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level39") {
					Level39 = new level39 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level39.json", Level39);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level40") {
					Level40 = new level40 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level40.json", Level40);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level41") {
					Level41 = new level41 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level41.json", Level41);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level42") {
					Level42 = new level42 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level42.json", Level42);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level43") {
					Level43 = new level43 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level43.json", Level43);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level44") {
					Level44 = new level44 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level44.json", Level44);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level45") {
					Level45 = new level45 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level45.json", Level45);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level46") {
					Level46 = new level46 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level46.json", Level46);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level47") {
					Level47 = new level47 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level47.json", Level47);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level48") {
					Level48 = new level48 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level48.json", Level48);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level49") {
					Level49 = new level49 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level49.json", Level49);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level50") {
					Level50 = new level50 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level50.json", Level50);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level51") {
					Level51 = new level51 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level51.json", Level51);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level52") {
					Level52 = new level52 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level52.json", Level52);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level53") {
					Level53 = new level53 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level53.json", Level53);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level54") {
					Level54 = new level54 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level54.json", Level54);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level55") {
					Level55 = new level55 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level55.json", Level55);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level56") {
					Level56 = new level56 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level56.json", Level56);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level57") {
					Level57 = new level57 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level57.json", Level57);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level58") {
					Level58 = new level58 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level58.json", Level58);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level59") {
					Level59 = new level59 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level59.json", Level59);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level60") {
					Level60 = new level60 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level60.json", Level60);
				}
			}
			else if (i > 2 && i <= 4) {
				image.sprite = sprite;
				image1.sprite = sprite;
				image2.sprite = sprite1;
				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Main") {
					Level1 = new level1 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level1.json", Level1);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level2") {
					Level2 = new level2 {
						completed=true,
						star=3
					};
					ResourceHelper.SaveToPersistentData ("level2.json", Level2);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level3") {
					Level3 = new level3 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level3.json", Level3);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level4") {
					Level4 = new level4 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level4.json", Level4);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level5") {
					Level5 = new level5 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level5.json", Level5);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level6") {
					Level6 = new level6 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level6.json", Level6);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level7") {
					Level7 = new level7 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level7.json", Level7);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level8") {
					Level8 = new level8 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level8.json", Level8);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level9") {
					Level9 = new level9 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level9.json", Level9);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level10") {
					Level10 = new level10 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level10.json", Level10);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level11") {
					Level11 = new level11 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level11.json", Level11);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level12") {
					Level12 = new level12 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level12.json", Level12);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level13") {
					Level13 = new level13 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level13.json", Level13);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level14") {
					Level14 = new level14 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level14.json", Level14);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level15") {
					Level15 = new level15 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level15.json", Level15);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level16") {
					Level16 = new level16 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level16.json", Level16);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level17") {
					Level17 = new level17 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level17.json", Level17);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level18") {
					Level18 = new level18 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level18.json", Level18);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level19") {
					Level19 = new level19 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level19.json", Level19);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level20") {
					Level20 = new level20 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level20.json", Level20);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level21") {
					Level21 = new level21 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level21.json", Level21);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level22") {
					Level22 = new level22 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level22.json", Level22);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level23") {
					Level23 = new level23 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level23.json", Level23);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level24") {
					Level24 = new level24 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level24.json", Level24);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level25") {
					Level25 = new level25 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level25.json", Level25);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level26") {
					Level26 = new level26 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level26.json", Level26);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level27") {
					Level27 = new level27 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level27.json", Level27);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level28") {
					Level28 = new level28 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level28.json", Level28);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level29") {
					Level29 = new level29 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level29.json", Level29);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level30") {
					Level30 = new level30 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level30.json", Level30);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level31") {
					Level31 = new level31 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level31.json", Level31);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level32") {
					Level32 = new level32 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level32.json", Level32);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level33") {
					Level33 = new level33 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level33.json", Level33);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level34") {
					Level34 = new level34 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level34.json", Level34);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level35") {
					Level35 = new level35 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level35.json", Level35);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level36") {
					Level36 = new level36 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level36.json", Level36);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level37") {
					Level37 = new level37 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level37.json", Level37);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level38") {
					Level38 = new level38 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level38.json", Level38);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level39") {
					Level39 = new level39 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level39.json", Level39);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level40") {
					Level40 = new level40 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level40.json", Level40);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level41") {
					Level41 = new level41 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level41.json", Level41);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level42") {
					Level42 = new level42 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level42.json", Level42);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level43") {
					Level43 = new level43 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level43.json", Level43);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level44") {
					Level44 = new level44 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level44.json", Level44);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level45") {
					Level45 = new level45 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level45.json", Level45);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level46") {
					Level46 = new level46 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level46.json", Level46);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level47") {
					Level47 = new level47 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level47.json", Level47);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level48") {
					Level48 = new level48 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level48.json", Level48);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level49") {
					Level49 = new level49 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level49.json", Level49);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level50") {
					Level50 = new level50 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level50.json", Level50);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level51") {
					Level51 = new level51 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level51.json", Level51);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level52") {
					Level52 = new level52 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level52.json", Level52);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level53") {
					Level53 = new level53 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level53.json", Level53);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level54") {
					Level54 = new level54 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level54.json", Level54);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level55") {
					Level55 = new level55 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level55.json", Level55);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level56") {
					Level56 = new level56 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level56.json", Level56);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level57") {
					Level57 = new level57 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level57.json", Level57);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level58") {
					Level58 = new level58 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level58.json", Level58);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level59") {
					Level59 = new level59 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level59.json", Level59);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level60") {
					Level60 = new level60 {
						completed=true,
						star=2
					};
					ResourceHelper.SaveToPersistentData ("level60.json", Level60);
				}
			}
			else if (i > 4) {
				image.sprite = sprite;
				image1.sprite = sprite1;
				image2.sprite = sprite1;
				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Main") {
					Level1 = new level1 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level1.json", Level1);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level2") {
					Level2 = new level2 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level2.json", Level2);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level3") {
					Level3 = new level3 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level3.json", Level3);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level4") {
					Level4 = new level4 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level4.json", Level4);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level5") {
					Level5 = new level5 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level5.json", Level5);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level6") {
					Level6 = new level6 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level6.json", Level6);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level7") {
					Level7 = new level7 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level7.json", Level7);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level8") {
					Level8 = new level8 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level8.json", Level8);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level9") {
					Level9 = new level9 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level9.json", Level9);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level10") {
					Level10 = new level10 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level10.json", Level10);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level11") {
					Level11 = new level11 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level11.json", Level11);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level12") {
					Level12 = new level12 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level12.json", Level12);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level13") {
					Level13 = new level13 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level13.json", Level13);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level14") {
					Level14 = new level14 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level14.json", Level14);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level15") {
					Level15 = new level15 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level15.json", Level15);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level16") {
					Level16 = new level16 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level16.json", Level16);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level17") {
					Level17 = new level17 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level17.json", Level17);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level18") {
					Level18 = new level18 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level18.json", Level18);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level19") {
					Level19 = new level19 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level19.json", Level19);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level20") {
					Level20 = new level20 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level20.json", Level20);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level21") {
					Level21 = new level21 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level21.json", Level21);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level22") {
					Level22 = new level22 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level22.json", Level22);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level23") {
					Level23 = new level23 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level23.json", Level23);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level24") {
					Level24 = new level24 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level24.json", Level24);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level25") {
					Level25 = new level25 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level25.json", Level25);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level26") {
					Level26 = new level26 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level26.json", Level26);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level27") {
					Level27 = new level27 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level27.json", Level27);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level28") {
					Level28 = new level28 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level28.json", Level28);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level29") {
					Level29 = new level29 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level29.json", Level29);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level30") {
					Level30 = new level30 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level30.json", Level30);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level31") {
					Level31 = new level31 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level31.json", Level31);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level32") {
					Level32 = new level32 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level32.json", Level32);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level33") {
					Level33 = new level33 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level33.json", Level33);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level34") {
					Level34 = new level34 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level34.json", Level34);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level35") {
					Level35 = new level35 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level35.json", Level35);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level36") {
					Level36 = new level36 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level36.json", Level36);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level37") {
					Level37 = new level37 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level37.json", Level37);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level38") {
					Level38 = new level38 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level38.json", Level38);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level39") {
					Level39 = new level39 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level39.json", Level39);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level40") {
					Level40 = new level40 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level40.json", Level40);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level41") {
					Level41 = new level41 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level41.json", Level41);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level42") {
					Level42 = new level42 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level42.json", Level42);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level43") {
					Level43 = new level43 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level43.json", Level43);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level44") {
					Level44 = new level44 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level44.json", Level44);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level45") {
					Level45 = new level45 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level45.json", Level45);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level46") {
					Level46 = new level46 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level46.json", Level46);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level47") {
					Level47 = new level47 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level47.json", Level47);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level48") {
					Level48 = new level48 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level48.json", Level48);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level49") {
					Level49 = new level49 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level49.json", Level49);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level50") {
					Level50 = new level50 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level50.json", Level50);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level51") {
					Level51 = new level51 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level51.json", Level51);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level52") {
					Level52 = new level52 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level52.json", Level52);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level53") {
					Level53 = new level53 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level53.json", Level53);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level54") {
					Level54 = new level54 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level54.json", Level54);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level55") {
					Level55 = new level55 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level55.json", Level55);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level56") {
					Level56 = new level56 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level56.json", Level56);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level57") {
					Level57 = new level57 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level57.json", Level57);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level58") {
					Level58 = new level58 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level58.json", Level58);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level59") {
					Level59 = new level59 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level59.json", Level59);
				}
				else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name=="Level60") {
					Level60 = new level60 {
						completed=true,
						star=1
					};
					ResourceHelper.SaveToPersistentData ("level60.json", Level60);
				}
			}
			this.enabled = false;
		}
        
        // On mouse down new line will be created 
        if(Input.GetMouseButtonDown(0))
        {
            if(line == null)
                createLine();
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(0,mousePos);
            startPos = mousePos;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            if(line)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1,mousePos);
                endPos = mousePos;
                addColliderToLine();
                line = null;
            }
        }
        else if(Input.GetMouseButton(0))
        {
            if(line)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1,mousePos);
            }
        }
    }
    // Following method creates line runtime using Line Renderer component
    private void createLine()
    {
        line = new GameObject("Line"+i).AddComponent<LineRenderer>();
        //line.material =  new Material(Shader.Find("Diffuse"));
        line.SetVertexCount(2);
        line.SetWidth(0.1f,0.1f);
        //line.SetColors(Color.black, Color.black);
        line.useWorldSpace = true;    
		i++;
		j++;
		a.Add (line);
		if (a.Count>=3) {

			Destroy (a [0].gameObject);

			a.RemoveAt (0);
		}

    }
    // Following method adds collider to created line
    private void addColliderToLine()
    {
        BoxCollider2D col = new GameObject("Collider").AddComponent<BoxCollider2D> ();
        col.transform.parent = line.transform; // Collider is added as child object of line
        float lineLength = Vector3.Distance (startPos, endPos); // length of line
        col.size = new Vector3 (lineLength, 0.1f, 1f); // size of collider is set where X is length of line, Y is width of line, Z will be set as per requirement
        Vector3 midPoint = (startPos + endPos)/2;
        col.transform.position = midPoint; // setting position of collider object
        // Following lines calculate the angle between startPos and endPos
        float angle = (Mathf.Abs (startPos.y - endPos.y) / Mathf.Abs (startPos.x - endPos.x));
        if((startPos.y<endPos.y && startPos.x>endPos.x) || (endPos.y<startPos.y && endPos.x>startPos.x))
        {
            angle*=-1;
        }
        angle = Mathf.Rad2Deg * Mathf.Atan (angle);
        col.transform.Rotate (0, 0, angle);
		col.gameObject.AddComponent<Rigidbody2D> ();
		col.attachedRigidbody.bodyType = RigidbodyType2D.Static;
		line.material = mat;


    }
}
public class level1
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level2
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level3
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level4
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level5
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level6
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level7
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level8
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level9
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level10
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level11
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level12
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level13
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level14
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level15
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level16
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level17
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level18
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level19
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level20
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level21
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level22
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level23
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level24
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level25
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level26
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level27
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level28
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level29
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level30
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level31
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level32
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level33
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level34
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level35
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level36
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level37
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level38
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level39
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level40
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level41
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level42
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level43
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level44
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level45
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level46
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level47
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level48
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level49
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level50
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level51
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level52
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level53
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level54
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level55
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level56
{
	public bool completed{ get; set;}
	public int star{get;set;}

}
public class level57
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level58
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level59
{
	public bool completed{ get; set;}
	public int star{get;set;}

}public class level60
{
	public bool completed{ get; set;}
	public int star{get;set;}

}

	


