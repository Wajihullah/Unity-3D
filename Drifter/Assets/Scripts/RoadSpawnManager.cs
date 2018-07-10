using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1 connects with 2 or 7
// 2 connects with 3 or 7
// 3 connects with 4 or 5
// 4 connects with 5 or 6
// 5 connects with 9
// 6 connects with 5 or 10 or 11
// 7 connects with 12 or 8
// 8 connects with 14 or 13
// 9 connects with 11
public class RoadSpawnManager : MonoBehaviour {

	// Use this for initialization
	public GameObject currentRoad;
	// public GameObject topRoad;
	public List<GameObject> roadPrefabs;
	// public GameObject currentRightBG;
	// public GameObject rightBG;
	// public GameObject topBG;
	void Start () {
		// for(int i =0;i<5;i++){
		// 	SpawnRoad();
		// }
		//print(currentRoad.transform.position.ToString());
		StartCoroutine(SpawnWithDelay(2f));
	}
	
	// Update is called once per frame
	void Update () {
		//SpawnRoad();
		//spawnRandom();
		
	}

	// void SpawnRoad(){
	// 	currentRoad = (GameObject)Instantiate(topRoad,currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	Debug.Log(currentRoad.transform.position.ToString());
	// }

	// void spawnRandom(){
	// 	if(currentRoad.tag.Equals("TopRoad1")){
	// 		int [] ar = {2,7};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		print(ar[roadNum]);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag=="TopRoad2"){
	// 		int [] ar = {3,7};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		print(roadNum);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad3"){
	// 		int [] ar = {4,5};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad4"){
	// 		int [] ar = {5,6};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad5"){
	// 		int [] ar = {9};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[9],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad6"){
	// 		int [] ar = {5,10,4};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad7"){
	// 		int [] ar = {8};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad8"){
	// 		int [] ar = {14,13};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad9"){
	// 		int [] ar = {12};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad10"){
	// 		int [] ar = {9};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad13"){
	// 		int [] ar = {8,12};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad14"){
	// 		int [] ar = {9};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad.tag == "TopRoad12"){
	// 		int [] ar = {8,12};
	// 		int roadNum = Random.Range(0,ar.Length);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// // 	//int a = Random.Range(0,2);
	// // 	//Debug.Log(a.ToString());
	// // 	currentRoad = (GameObject)Instantiate(roadPrefabs[1],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// // 	if(currentRoad = roadPrefabs[1]){
	// // 		//int road = Random.Range(2,4);
	// // 		currentRoad = (GameObject)Instantiate(roadPrefabs[2],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// // 	}
	// // 	if(currentRoad = roadPrefabs[2]){
	// // 		int road = Random.Range(2,5);
	// // 		currentRoad = (GameObject)Instantiate(roadPrefabs[road],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// // 	}
	// // 	if(currentRoad=roadPrefabs[3]){
	// // 		currentRoad = (GameObject)Instantiate(roadPrefabs[0],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// // 	}
	// // 	if(currentRoad=roadPrefabs[4]){
	// // 		currentRoad = (GameObject)Instantiate(roadPrefabs[0],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// // 	}
	// }
	void spawnRandom1(){
		if(currentRoad.tag.Equals("TopRoad1")){
			int [] ar = {0};
			int roadNum = Random.Range(0,ar.Length);
			print(ar[roadNum]);
			currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		}
		// if(currentRoad.tag=="TopRoad2"){
		// 	int [] ar = {3};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	print(roadNum);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad3"){
		// 	int [] ar = {4};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad4"){
		// 	int [] ar = {5};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad5"){
		// 	int [] ar = {11};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[11],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad11"){
		// 	int [] ar = {15};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[15],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }if(currentRoad.tag == "TopRoad15"){
		// 	int [] ar = {16};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[16],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad16"){
		// 	int [] ar = {15};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[15],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad6"){
		// 	int [] ar = {5,10,4};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad7"){
		// 	int [] ar = {8};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad8"){
		// 	int [] ar = {14,13};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad9"){
		// 	int [] ar = {12};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[roadNum]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad10"){
		// 	int [] ar = {9};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad13"){
		// 	int [] ar = {8,12};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad14"){
		// 	int [] ar = {9};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
		// if(currentRoad.tag == "TopRoad12"){
		// 	int [] ar = {8,12};
		// 	int roadNum = Random.Range(0,ar.Length);
		// 	currentRoad = (GameObject)Instantiate(roadPrefabs[ar[0]],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
		// }
	// 	//int a = Random.Range(0,2);
	// 	//Debug.Log(a.ToString());
	// 	currentRoad = (GameObject)Instantiate(roadPrefabs[1],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	if(currentRoad = roadPrefabs[1]){
	// 		//int road = Random.Range(2,4);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[2],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad = roadPrefabs[2]){
	// 		int road = Random.Range(2,5);
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[road],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad=roadPrefabs[3]){
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[0],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	// 	if(currentRoad=roadPrefabs[4]){
	// 		currentRoad = (GameObject)Instantiate(roadPrefabs[0],currentRoad.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	// 	}
	}

// void SpawnBg(){
// 	currentRightBG = (GameObject) Instantiate(rightBG,currentRightBG.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
// 	currentRightBG = (GameObject) Instantiate(topBG,currentRightBG.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
// }
IEnumerator SpawnWithDelay(float _delay){
	while(true){
	spawnRandom1();
	//SpawnBg();
	yield return new WaitForSeconds(_delay);
	//print(Tags.CarTags[CarTags.TopRoad0.GetHashCode()]);
	}
}

}

// public static class Tags{
// 	public static List<string> CarTags = new List<string>();
// }

// public enum CarTags{
// 	TopRoad0=0,TopRoad1=1
// }