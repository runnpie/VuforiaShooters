﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField]
    GameObject Enemy;

    [SerializeField]
    GameObject Astero;

    [SerializeField]
    GameObject Spawncube;

    float Countdown;
    float LifeTime = 2f;
    bool Isdead = false;
    float danger = 0;

    private void Awake()
    {
        Countdown = LifeTime;
        EnemyBehaviour.isdead = false;
        Scoring.point = 0;
    }
	
	void Update ()
    {
        if (Countdown <= 0)

        {
            Vector3 sposition = new Vector3(Random.Range(Mathf.Clamp(-1500,-1500,-400 ), Mathf.Clamp(1500,400, 1500.0f)), 204f, Random.Range(Mathf.Clamp(-1500,-400, -1500.0f),Mathf.Clamp(1500,400, 1500.0f)));
             Debug.Log(sposition.ToString("F4"));
      
                Instantiate(Astero, sposition, Spawncube.transform.rotation);
                Countdown = LifeTime;
                if (danger % 3 == 0)
                {
                    Vector3 sposition2 = new Vector3(Random.Range(Mathf.Clamp(-1500, -1500, -400), Mathf.Clamp(1500, 400, 1500.0f)), 204f, Random.Range(Mathf.Clamp(-1500, -400, -1500.0f), Mathf.Clamp(1500, 400, 1500.0f)));
                   

                    Instantiate(Enemy, sposition2, Spawncube.transform.rotation);


                }
                danger++;
                
        }
        else
        {
            Countdown -= Time.deltaTime;
        }




    }
}
