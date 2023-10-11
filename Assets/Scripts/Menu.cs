using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame () {
        Debug.Log("Start Game");
        // Load the scene named "Game"
        // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
