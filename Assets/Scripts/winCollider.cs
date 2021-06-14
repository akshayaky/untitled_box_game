using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//to load the next level when the player enters the win trigger
public class winCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collition) {
    	GameObject collitionObject = collition.gameObject;
    	if(collitionObject.name == "little_box") {
    		LoadScene();
    	}
    }
    
    void LoadScene() {
    	SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }
}
