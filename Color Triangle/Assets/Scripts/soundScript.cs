using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundScript : MonoBehaviour {

    public static AudioClip colSound, starSound;
    static AudioSource aus;
	// Use this for initialization
	void Start () {
        colSound = Resources.Load<AudioClip>("col");
        starSound = Resources.Load<AudioClip>("star");

        aus = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        aus.volume = 0.5f;
		
	}
    public static void playSound(string clip)
    {
        switch (clip)
        {
            case "col":
                aus.PlayOneShot(colSound);
                break;
            case "star":
                aus.PlayOneShot(starSound);
                break;
        }
    }
}
