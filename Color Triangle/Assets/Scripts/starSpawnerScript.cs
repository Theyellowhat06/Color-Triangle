using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawnerScript : MonoBehaviour {

    public GameObject star;
    public GameObject shield;

    private float timer;
    private float stimer;
    private float ind = 1;

    // Use this for initialization
    void Start () {
        timer = Random.Range(0, 30);
        stimer = Random.Range(0, 30);
	}
	
	// Update is called once per frame
	void Update () {
        

        if (spawnerScript.gameOn)
        {
            timer -= Time.deltaTime;
            stimer -= Time.deltaTime;
            if (timer <= 0)
            {
                Instantiate(star);
                timer = Random.Range(0, 30);

            }
            if (stimer <= 0)
            {
                ind = Random.Range(0, 10);
                print(ind);
                if (ind == 0)
                {
                    Instantiate(shield);
                }
                stimer = Random.Range(0, 30);
            }
            
        }
    }
}
