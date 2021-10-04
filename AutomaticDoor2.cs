using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor2 : MonoBehaviour
{
    Animator anim;
    BoxCollider2D bc;
    bool activeDoor = false;
    public Button bt;
    void Start()
    {
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (bt.pressed == true)
        {
            activeDoor = true;
        }
        if (activeDoor == true)
        {
            anim.SetBool("OpenDoor", true);
            bc.enabled = false;
        }
    }
}
