using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitAudio : MonoBehaviour
{
	public AudioSource audioSrc;

    void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "block") {//gravity increase
    		audioSrc.volume = 0.8f;
			if(!audioSrc.isPlaying){
				audioSrc.Play();
			}
		}
    }

    void OnCollisionExit2D(Collision2D col) {
    	if(col.gameObject.tag == "block") {//gravity increase
    		audioSrc.volume = 0.2f;
			// audioSrc.Pause();
		}	
    }
}
