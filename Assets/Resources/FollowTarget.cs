using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
	private GameObject target;
	public float speed = 0.05f;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("ARCamera");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed); 
		transform.LookAt(target.transform); 
	}
}
