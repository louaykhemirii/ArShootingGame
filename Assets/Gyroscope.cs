using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gyroscope : MonoBehaviour
{
   

public class rot : MonoBehaviour
{

	Quaternion initialQuat;
	Quaternion attitudeFix;
	Quaternion attitudeRel;
	Text sondas;

	void Start()
	{
		Input.gyro.enabled = true;
		initialQuat = Input.gyro.attitude;
		sondas = GameObject.Find("Gyro").GetComponent<Text>();

	}

	void Update()
	{
		attitudeRel = Input.gyro.attitude * initialQuat;
		attitudeFix = new Quaternion(attitudeRel.x, -attitudeRel.z, attitudeRel.y, attitudeRel.w);
		transform.rotation = attitudeFix;
		sondas.text = "" + Input.gyro.enabled + attitudeFix;
	}

}
}
