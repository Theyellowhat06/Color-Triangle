using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour {

    public float speed;

    public Color Green;
    public Color Red;
    public Color Blue;

    public SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        colorSwitch();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
	}
    private void colorSwitch()
    {
        int ind = Random.Range(0, 6);
        switch (ind)
        {
            case 0:
                transform.gameObject.tag = "Green";
                sr.color = Green;
                break;
            case 1:
                transform.gameObject.tag = "Red";
                sr.color = Red;
                break;
            case 2:
                transform.gameObject.tag = "Blue";
                sr.color = Blue;
                break;
            case 3:
                transform.gameObject.tag = "Red";
                sr.color = Red;
                break;
            case 4:
                transform.gameObject.tag = "Green";
                sr.color = Green;
                break;
            case 5:
                transform.gameObject.tag = "Blue";
                sr.color = Blue;
                break;
        }

    }
}
