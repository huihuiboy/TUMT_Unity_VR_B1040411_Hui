using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;


public class game : MonoBehaviour {

    public int score = 0;
    public Text scr;


    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ball")
        {
            score += 10;
            scr.text = "Score: " + score;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ball")
        {
            score -= 10;
            scr.text = "Score: " + score;
        }
    }
}
