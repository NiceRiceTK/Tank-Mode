﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DespawnExposion());

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DespawnExposion()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }
}
