using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUp : MonoBehaviour
{
    float speed;
    bool move;
    bool stopMoviment;
    void Start()
    {
        speed = 3;
        move = false;
        stopMoviment = false;
    }

    void Update()
    {
        if (move == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (stopMoviment == true)
        {
            move = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (stopMoviment == false && collision.gameObject.CompareTag("Player"))
            {
                move = true;
            }
            else
            {
                move = false;
            }
          
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("StopElevator"))
        {
            stopMoviment = true;
            Debug.Log("Can't Move!");
        }
    }
}
