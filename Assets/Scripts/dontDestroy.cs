using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour
{
	/*
		Awake keeps the gameObjects with tag "music" alive thorughout the scenes.
    */
    void Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1) {
        	Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update() {
    	int index = SceneManager.GetActiveScene().buildIndex;
    	if(index == 0 || index >= SceneManager.sceneCountInBuildSettings - 2) {
    		Cursor.lockState = CursorLockMode.None;
        	Cursor.visible = true;	
    	}
    	else {
    		Cursor.lockState = CursorLockMode.Locked;
        	Cursor.visible = false;

            if(Input.GetKeyDown("r")) {
                SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
            }
    	}
    }
}
