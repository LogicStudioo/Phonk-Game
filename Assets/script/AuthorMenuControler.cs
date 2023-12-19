using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AuthorMenuControler : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Back");
    }
}
