using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationScene3 : MonoBehaviour
{
    float maxTime;
    float timer;
    public bool changeLevel;
    public Boss bs;
    void Start()
    {
        maxTime = 4;
        timer = 0;
        changeLevel = false;
    }
    void Update()
    {
        if (bs.defeated == true)
        {
            changeLevel = true;
        }
        if (changeLevel == true)
        {
            timer += Time.deltaTime;
            if (timer > maxTime)
            {

                SceneManager.LoadScene(0);
            }
        }
    }
}
