using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Animator anim;
    public bool pressed;
    void Start()
    {
        anim = GetComponent<Animator>();
        pressed = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Pressed", true);
            pressed = true;
        }        
    }

}
