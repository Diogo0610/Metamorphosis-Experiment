using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    float maxTime;
    float offAnimation;
    float timer;
    Animator anim;
    BoxCollider2D bc;
    void Start()
    {
        maxTime = 2;
        timer = 0;
        offAnimation= 4;
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();
        bc.enabled = false;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime)
        {
            bc.enabled = true;
            anim.SetBool("LaserActive", true);
        }
        if (timer > offAnimation)
        {
            bc.enabled = false;
            anim.SetBool("LaserActive", false);
            timer = 0;
        }

    }
}
