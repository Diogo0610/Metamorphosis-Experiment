using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AnimationScene2 : MonoBehaviour
{
    float maxTime;
    float timer;
    public bool changeLevel;
    void Start()
    {
        maxTime = 4;
        timer = 0;
        changeLevel = false;
    }
    void Update()
    {
        if (changeLevel == true)
        {
            timer += Time.deltaTime;
            if (timer > maxTime)
            {
                Debug.Log("Level 2");
                SceneManager.LoadScene(3);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            changeLevel = true;
        }
    }
}
