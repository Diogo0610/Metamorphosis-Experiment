using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    MeshRenderer mr;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            mr.material.mainTextureOffset += Vector2.right * 0.1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            mr.material.mainTextureOffset -= Vector2.left * -0.1f * Time.deltaTime;
        }

    }
}
