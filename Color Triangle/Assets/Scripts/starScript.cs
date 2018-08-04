using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starScript : MonoBehaviour {

    public static int starValue = 0;
    private Text star;

	// Use this for initialization
	void Start () {
        star = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        star.text = "" + starValue;
	}
}
