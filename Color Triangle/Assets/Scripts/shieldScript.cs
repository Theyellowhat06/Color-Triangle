using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour {

    private float speed = 17.144f;
    private float rotate = 0;
    private int count = 0;

    public CameraShake cameraShake;

    // Use this for initialization
    void Start () {
        transform.Rotate(0, 0, 120 * triangleScript.ind);
	}
	
	// Update is called once per frame
	void Update () {

        if (triangleScript.rtt)
        {


            rotate += speed;
            transform.Rotate(0, 0, speed);
            print(rotate);
            if (rotate > 119)
            {
                
                rotate = 0;
            }
        }
        if(count > 9)
        {
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Green" || col.tag == "Red" || col.tag == "Blue")
        {
            scoreScript.scoreValue += 1;
            soundScript.playSound("col");
            count++;
            Destroy(col.gameObject);
        }
        if (col.tag == "Shield")
        {
            count -= 10;
            Destroy(col.gameObject);
        }
    }
}
