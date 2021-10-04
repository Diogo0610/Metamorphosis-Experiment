using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Criar um Material
//Atrelar o sprite do background no material criado
//No sprite, definir como Repeat, não Clamp
//Aplicar esse material em um Quad
public class BackgroundMovement : MonoBehaviour
{
    MeshRenderer mr;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        mr.material.mainTextureOffset += Vector2.right * 0.1f * Time.deltaTime; // Background se move sozinho
        // Background se move de acordo com o movimento do personagem
        /*
        if (Input.GetKey(KeyCode.D))
        {
            mr.material.mainTextureOffset += Vector2.right * 0.1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            mr.material.mainTextureOffset -= Vector2.left * -0.1f * Time.deltaTime;
        }
        */

    }
}
