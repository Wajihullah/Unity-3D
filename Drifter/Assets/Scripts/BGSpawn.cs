using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawn : MonoBehaviour
{

    // Use this for initialization
    public GameObject topBG;
    public GameObject rightBG;
    public GameObject currentBG;

    public GameObject leftBG;
    public GameObject downBG;
    public GameObject currDBG;

	public GameObject Left;
	public GameObject Right;
	
    float y = 0f;
	float lx = -5.5f;
	float ly = 0f;
    float Dy = 0f;
	float Dx = 0f;
	float DRx = 0f;
	float DRy = 0f;
    void Start()
    {

        Spawner();
    }

    public void Spawner()
    {
        for (int i = 0; i < 10; i++)
        {

            currentBG = (GameObject)Instantiate(topBG, currentBG.transform.GetChild(0).transform.GetChild(1).transform.position, Quaternion.identity);

            for (int j = 0; j < 10; j++)
            {
                Vector3 Lpos = new Vector3(lx,ly,0);
				Vector3 DRpos = new Vector3(DRx,DRy,0);
				Vector3 pos = currentBG.transform.GetChild(0).transform.GetChild(0).transform.position;
                Vector3 Dpos = currDBG.transform.GetChild(0).transform.GetChild(2).transform.position;
                if (j == 0)
                {
                    Vector3 v = new Vector3(-5.5f, y, 0);
                    y += 19.2f;
                    pos = v;
                    Dy -= 19.2f;
					Dx = 0;
				    lx = 0f;
				    ly += 19.2f;
					DRx = 0f;
					DRy -= 19.2f; 
                }
				 Vector3 Dv = new Vector3(Dx, Dy, 0);
                    Dx -= 10.8f;
                    Dpos = Dv;
					lx -= 10.8f;
					DRx += 10.8f;
                currentBG = (GameObject)Instantiate(rightBG, pos, Quaternion.identity);
                downBG = (GameObject)Instantiate(leftBG, Dpos, Quaternion.identity);
				GameObject.Instantiate(Left,Lpos,Quaternion.identity);
				GameObject.Instantiate(Right,DRpos,Quaternion.identity);}
        }
    }
}
