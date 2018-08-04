using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallScript : MonoBehaviour {

    public float fallingSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector2.down * fallingSpeed * Time.deltaTime);

    }
}
