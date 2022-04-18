using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour {

	public GameObject[] prefabs;//road prefabs
	public Transform startPos;
	int nextStep;
	public float speed = 0.00001f;

	// Update is called once per frame
	void Update () {

		nextStep += 40;
		Instantiate (prefabs[Random.Range(0,prefabs.Length)],new Vector3(startPos.position.x,startPos.position.y,startPos.position.z+nextStep),Quaternion.identity);


	}


}
