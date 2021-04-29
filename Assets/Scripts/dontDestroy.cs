﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour
{
	/*
		Awake keeps the gameObjects with tag "music" alive thorughout the scenes.
	    This is to keep the music playing without restarting.
    */
    void Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1) {
        	Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void FixedUpdate() {
    	int index = SceneManager.GetActiveScene().buildIndex;
    	if(index == 0 || index == 9) {
    		Cursor.lockState = CursorLockMode.None;
        	Cursor.visible = true;	
    	}
    	else {
    		Cursor.lockState = CursorLockMode.Locked;
        	Cursor.visible = false;
    	}
    }
}
