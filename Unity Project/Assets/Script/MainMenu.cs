using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void PlayCreds()
    {
        SceneManager.LoadScene(7);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

     public void PlayGame2 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

     public void PlayGame3 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }

     public void PlayGame4 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }

     public void PlayGame5 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }
    
     public void PlayGame6 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);

    }
}
