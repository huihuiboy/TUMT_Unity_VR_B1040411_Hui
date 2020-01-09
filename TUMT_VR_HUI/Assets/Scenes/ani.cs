using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour {

    float speed = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(0, speed, 0,Space.Self);

	}
}
