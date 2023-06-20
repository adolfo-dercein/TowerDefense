using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_btn : MonoBehaviour
{
    public void MoveToScente ( int MainScene) {
        SceneManager.LoadScene(MainScene);
    }

   
 
}
