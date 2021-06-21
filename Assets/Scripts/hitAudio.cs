using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitAudio : MonoBehaviour
{
	public AudioSource audioSrc;

    void OnCollisionStay2D(Collision2D col) {
		if(col.gameObject.tag == "block") {
    		audioSrc.spatialBlend = 0f;
			if(!audioSrc.isPlaying){
				audioSrc.Play();
			}
		}
    }

    void OnCollisionExit2D(Collision2D col) {
    	if(col.gameObject.tag == "block") {
    		audioSrc.spatialBlend = 0.8f;
		}	
    }
}
