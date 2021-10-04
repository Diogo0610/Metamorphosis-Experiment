using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Manager : MonoBehaviour
{
    public GameObject player;
    bool spawn;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = true;
    }

    void Update()
    {
        if (spawn == true)
        {
            player.transform.position = new Vector3(0,-2, 0);
            spawn = false;
        }
    }
}
