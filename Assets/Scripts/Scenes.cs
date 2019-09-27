using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    public void StartPlay()
    {
        SceneManager.LoadScene("Main Scene 1");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
    public void StopPlaying()
    {
        SceneManager.LoadScene("Outro");
    }

   
}
