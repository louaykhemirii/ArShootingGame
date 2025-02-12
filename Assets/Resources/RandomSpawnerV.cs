﻿using UnityEngine;
using System.Collections;

public class RandomSpawnerV : MonoBehaviour {
	public GameObject[] enemies;
	public int maxtimer = 10;
	public int mintimer = 3;
	private float timer;
	private float timetospawn;
	public int xmin=-20, xmax=20;
	public int ymin=-10,ymax=10;
	private int objX,objY;
	// Use this for initialization
	void Start () {
		timetospawn = Random.Range(mintimer, maxtimer);	 
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > timetospawn){ 			
			timer = 0; 
			timetospawn = Random.Range(mintimer, maxtimer); 
			Debug.Log(timetospawn); 
			RandomPosition();
			Spawn(Random.Range(0, enemies.Length)); 
		}	
	}

	void RandomPosition(){
		objX = Random.Range(xmin, xmax);
		objY = Random.Range(ymin, ymax);
	}

	void Spawn(int index){
		Instantiate(enemies[index],new Vector3(objX,objY,transform.position.z),transform.rotation); 
	}
}
