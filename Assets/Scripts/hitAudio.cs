using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitAudio : MonoBehaviour
{
	public AudioSource audioSrc;

  //   void OnCollisionEnter2D(Collision2D col) {
		// if(col.gameObject.tag == "block") {//gravity increase
  //   		audioSrc.spatialBlend = 0f;
		// 	if(!audioSrc.isPlaying){
		// 		audioSrc.Play();
		// 	}
		// }
  //   }

    void OnCollisionStay2D(Collision2D col) {
		if(col.gameObject.tag == "block") {//gravity increase
    		audioSrc.spatialBlend = 0f;
			if(!audioSrc.isPlaying){
				audioSrc.Play();
			}
		}
    }

    void OnCollisionExit2D(Collision2D col) {
    	if(col.gameObject.tag == "block") {//gravity increase
    		audioSrc.spatialBlend = 0.8f;
			// audioSrc.Pause();
		}	
    }
}
