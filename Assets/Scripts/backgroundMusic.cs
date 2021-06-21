using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundMusic : MonoBehaviour
{
    public AudioSource audioS1;

    // Update is called once per frame
    void Update()
    {
    	int level = SceneManager.GetActiveScene().buildIndex;
    	if(!(level == 0)) {
    		audioS1.Stop();
    	}
        else{
            if(!audioS1.isPlaying)
                audioS1.Play();
        }
    }
}
