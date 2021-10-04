using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    Animator anim;
    BoxCollider2D bc;
    bool activeDoor = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (activeDoor == true)
        {
            anim.SetBool("OpenDoor", true);
            bc.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            activeDoor = true;
        }
    }
}
