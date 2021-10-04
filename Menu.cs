using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Howtoplay()
    {
        SceneManager.LoadScene(4);
    }
}
