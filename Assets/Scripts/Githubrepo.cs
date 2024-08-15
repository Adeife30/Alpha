// this code from robert smith



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Added this line to use SceneManager

public class Githubrepo : MonoBehaviour
{
    public string URL = "https://github.com/Adeife30/Alpha.git";
 
    public void loadUrl()
    {
        Application.OpenURL(URL);
    }

    public void Level0()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Gamewon()
    {
        SceneManager.LoadScene("Game won");
    }
} // This is the correct closing brace for the class
