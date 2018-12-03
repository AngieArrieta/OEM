using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {
    bool pause;
    Canvas canvas;
	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();
        //canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
            //canvas.enabled = pause;
            Time.timeScale = (pause) ? 0 : 1f;
        }
	}
}
