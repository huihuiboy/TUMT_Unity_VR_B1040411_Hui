using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jum : MonoBehaviour {

    public float Jum = 0.5f;

    public int CC =15;

    int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (count == 0)
        {
        this.transform.Translate(0, Jum, 0,Space.Self);
            count++;
           
        }
        else if (count == 10)
        {
            this.transform.Translate(0, -Jum , 0, Space.Self);
            count++;

        }
        else if (count< CC && count >0)
        {
            
            count ++;

        }
        else if (count == CC)
        {

            count = 0;

        }

    }
}
