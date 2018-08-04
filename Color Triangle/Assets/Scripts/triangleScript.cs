using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triangleScript : MonoBehaviour {


    public static bool rtt = false;

    public static int ind = 0;

    private float speed = 15;
    private float rotate = 0;
    

    public CameraShake cameraShake;

    public GameObject shield;

    public string color;

	// Use this for initialization
	void Start () {
        scoreScript.scoreValue = 0;
        starScript.starValue = 0;
        ind = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
		if (Input.GetMouseButtonDown(0) && rtt == false)
        {
            rtt = true;
            ind++;
            if (ind > 2)
            {
                ind = 0;
            }
            colorRotate(ind);

        }
        
        if (rtt)
        {
            

            rotate += speed;
            transform.Rotate(0, 0, speed);

            if (rotate > 119)
            {
                rtt = false;
                rotate = 0;
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == color)
        {
            scoreScript.scoreValue += 1;
            soundScript.playSound("col");
            Destroy(col.gameObject);
            StartCoroutine(cameraShake.Shake(.1f, .05f));
        }
        else if(col.tag == "Star")
        {
            starScript.starValue += 10;
            allStartsScript.allstars += 10;
            soundScript.playSound("star");
            Destroy(col.gameObject);
        }
        else if(col.tag == "Shield")
        {
            Instantiate(shield);
            Destroy(col.gameObject);
        }
        else if(col.tag == "BigShield")
        {
            
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void colorRotate(int num)
    {

        switch (num)
        {
            case 0:
                color = "Green";
                break;
            case 1:
                color = "Red";
                break;
            case 2:
                color = "Blue";
                break;
        }
    }

}
