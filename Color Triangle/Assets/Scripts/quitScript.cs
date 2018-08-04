using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitScript : MonoBehaviour {
    private bool canQuit = false;
    private float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape) && canQuit == false)
        {
            canQuit = true;
            time = 1;
            Debug.Log("Tap one more time.");
        }
        
        if (canQuit == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("Quiting");
                Application.Quit();
                
            }
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            canQuit = false;
        }
    }
}
