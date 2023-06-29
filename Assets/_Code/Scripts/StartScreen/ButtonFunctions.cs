using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

public void PlayGame (){
    SceneManager.LoadScene("MainScene");
}

    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound () {
        mySounds.PlayOneShot(hoverSound);
    }
    public void ClickSound () {
        mySounds.PlayOneShot(clickSound);
    }
  
}
