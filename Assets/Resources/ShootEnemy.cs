using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootEnemy : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject feathers;
    public Text coinText;
    private float coinScore;



    private void Awake()
    {
        coinText.text = coinScore.ToString("0");

    }


    public void Shoot(AudioSource shotgun)
    {
        shotgun.Play();
        RaycastHit hit;



        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "Cube(Clone)"||hit.transform.name== "Enemy(Clone)")
            {
                coinScore++;
                coinText.text = coinText.text = coinScore.ToString("0");


                Destroy(hit.transform.gameObject);

                Instantiate(feathers, hit.point, Quaternion.LookRotation(hit.normal));

            }
        }
    }
}
