using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour
{
    public GameObject MusicGarden;
    public GameObject MusicLab;
    void Start()
    {
        MusicGarden.SetActive(true);
        MusicLab.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MusicGarden.SetActive(false);
            MusicLab.SetActive(true);
        }
    }
}
