using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class playButton : MonoBehaviour
{
	public GameObject gb;
	public AudioSource aSrc;
	private int level = 0;
	void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0){
        	PlayerPrefs.SetInt("level",0);//used to remember the previous level when in the win scene
        	PlayerPrefs.Save();
        }
    }

    // void FixedUpdate(){
    // 	aSrc = gb.GetComponent<backgroundMusic>().currentAudioSrc;
    // }

    public void NextLevel() {
    	level = PlayerPrefs.GetInt("level");
    	PlayerPrefs.SetInt("level", level + 1);
    	SceneManager.LoadScene(level + 1);
    }

    public void ReplayLevel() {
    	level = PlayerPrefs.GetInt("level");
    	SceneManager.LoadScene(level);	
    }

    //function to reduce the volume of the background music
    public void overButton() {
    	// if (aSrc.panStereo == 0)
    	// 	aSrc.panStereo = 1f;
    	// else if(aSrc.panStereo == -1f)
    	// 	aSrc.panStereo = 0f;
    	// aSrc.volume = 0.2f;
    	aSrc.spatialBlend = 0.7f;
    }

    public void outofButton() {
    	// if (aSrc.panStereo == 1f)
    	// 	aSrc.panStereo = -1f;
    	// aSrc.volume = 1f;
    	aSrc.spatialBlend = 0f;

    }
}
