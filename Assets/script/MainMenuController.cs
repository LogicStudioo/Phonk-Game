using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Ini Game");
    }
    public void OpenAuthor()
    {
        SceneManager.LoadScene("Author");
        Debug.Log("Testooo");
    }
}
