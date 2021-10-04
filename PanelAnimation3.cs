using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimation3 : MonoBehaviour
{
    [SerializeField] public AnimationScene3 AS;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AS.changeLevel == true)
        {
            anim.SetBool("EndLevel", true);
        }
    }
}
