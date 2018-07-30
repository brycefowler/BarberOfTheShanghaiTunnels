using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    //public void PlayGame ()
    //{
    //    SceneManager.LoadScene ("Game");
    //    Debug.Log("Gah");
    //}

    public void LoadByIndex (int sceneIndex)
    {
        SceneManager.LoadScene (sceneIndex);

    }

    public void QuitGame ()
    {
        Application.Quit ();
    }
}
