using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class allStartsScript : MonoBehaviour {

    private Text stars;
    public static int allstars = 0;

    // Use this for initialization
    void Start()
    {
        stars = GetComponent<Text>();
        allstars = PlayerPrefs.GetInt("Stars");
    }

    // Update is called once per frame
    void Update()
    {
        
        stars.text = "" + allstars;
        PlayerPrefs.SetInt("Stars", allstars);
    }
}
