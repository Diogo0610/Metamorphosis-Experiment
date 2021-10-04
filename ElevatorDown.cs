using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDown : MonoBehaviour
{
    float speed;
    bool move;
    void Start()
    {
        speed = 3;
        move = false;
    }

    void Update()
    {
        if (move == true)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            move = true;
        }
    }
}
