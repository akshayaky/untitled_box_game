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
    		if(SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 3){
                LoadScene(SceneManager.sceneCountInBuildSettings - 1);
            }
            else{
                LoadScene(SceneManager.sceneCountInBuildSettings - 2);
            }
    	}
    }

    void LoadScene(int index) {
    	SceneManager.LoadScene(index);
    }
}
