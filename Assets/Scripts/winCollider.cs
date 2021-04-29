using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//to load the next level when the player enters the win trigger
public class winCollider : MonoBehaviour
{
	public int winIndex = 9; // 9 is the build index of the UI screen between the levels
    void OnTriggerEnter2D(Collider2D collition) {
    	GameObject collitionObject = collition.gameObject;
    	if(collitionObject.name == "little_box") {
    		LoadScene();
    	}
    }
    
    void LoadScene() {
    	SceneManager.LoadScene(winIndex);
    }
}
