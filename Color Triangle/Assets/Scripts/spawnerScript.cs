using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour {

    public static bool gameOn = false;
    public GameObject[] wall;
    private float delayTimer = 1.525f;
    private float timer;

	// Use this for initialization
	void Start () {
        timer = 0;
        gameOn = false;
	}
	
	// Update is called once per frame
	void Update () {
        int element = Random.Range(0, 5);
        timer -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            gameOn = true;
        }
        if (timer <= 0 && gameOn)
        {
            Instantiate(wall[element]);
            if (delayTimer >= 0.7f)
            {
                delayTimer -= 0.025f;
            }
            
            
            timer = delayTimer;
        }
	}
}
