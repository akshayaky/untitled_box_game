using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundMusic : MonoBehaviour
{
    public AudioSource audioS1;
    public AudioSource audioS2;
    public AudioSource audioS3;
    public AudioSource currentAudioSrc;
    private int currentAudioS;
    
    void Start()
    {
        currentAudioS = Random.Range(0,3);
        // Debug.Log(currentAudioS);
    }

    // Update is called once per frame
    void Update()
    {
    	int level = SceneManager.GetActiveScene().buildIndex;
    	if( !audioS1.isPlaying && !audioS2.isPlaying && !audioS2.isPlaying )
    	{
    		currentAudioS = Random.Range(0,3);
	        if(currentAudioS == 0) {
	        	currentAudioSrc = audioS1;
	        	audioS1.Play();
	        }
	        else if(currentAudioS == 1) {
	        	currentAudioSrc = audioS2;
	        	audioS2.Play();
	        }
	        else if(currentAudioS == 2) {
	        	currentAudioSrc = audioS2;
	        	audioS3.Play();
	        }
    	}
    	if(!(level == 0)) {
    		audioS1.Stop();
    		audioS2.Stop();
    		audioS3.Stop();
    	}
    }
}
