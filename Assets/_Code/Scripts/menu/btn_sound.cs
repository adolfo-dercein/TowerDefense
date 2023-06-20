using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_sound : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound (){
        audio.PlayOneShot(hoverSound);
    }
    public void ClickSound(){
        audio.PlayOneShot( clickSound);
    }
}
