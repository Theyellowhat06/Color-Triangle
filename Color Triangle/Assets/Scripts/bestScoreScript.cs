using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestScoreScript : MonoBehaviour {

    private Text bestScore;
    private static int bscore = 0;

	// Use this for initialization
	void Start () {
        bestScore = GetComponent<Text>();
        bscore = PlayerPrefs.GetInt("BestScore");
	}
	
	// Update is called once per frame
	void Update () {
		if (bscore < scoreScript.scoreValue)
        {
            bscore = scoreScript.scoreValue;
        }
        bestScore.text = "" + bscore;
        PlayerPrefs.SetInt("BestScore", bscore);
	}
}
