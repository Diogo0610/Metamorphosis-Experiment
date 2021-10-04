using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGround : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Destroy(gameObject, 0.3f);
        }
    }
}
