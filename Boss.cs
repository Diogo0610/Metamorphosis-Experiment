using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    SpriteRenderer sr;
    int lifeBoss;
    public bool defeated;
    public Text bossLife;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        lifeBoss = 10;
        defeated = false;
    }
    void Update()
    {
        bossLife.text = "" + lifeBoss;
        if (lifeBoss == 0)
        {
            defeated = true;
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flip"))
        {
            sr.flipX = false;
        }
        if (collision.gameObject.CompareTag("Fliptrue"))
        {
            sr.flipX = true;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            lifeBoss--;
        }
    }
}
