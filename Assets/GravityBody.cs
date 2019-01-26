using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour {

    public GravityAttractor attractor;
    public Transform myTransform;

	void Start () {
        myTransform = transform;
		
	}
	
	// Update is called once per frame
	void Update () {
        attractor.Attract(myTransform);
	}
}
