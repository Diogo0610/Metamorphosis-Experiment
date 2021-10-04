using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator anim;
    bool openDoor;
    BoxCollider2D bc;
    void Start()
    {
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();
        openDoor = false;
    }
    void Update()
    {
        if (openDoor == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetBool("canOpen_anim", true);
                bc.enabled = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            openDoor = true;
        }
        else
        {
            openDoor = false;
        }
    }
}
