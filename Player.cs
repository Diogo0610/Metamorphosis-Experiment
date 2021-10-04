using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed, jumpForce;
    private Rigidbody2D rb;
    SpriteRenderer sr;
    public Text lifeText;
    public int life;
    Animator anim;
    bool flying;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        flying = false;
    }

    void Update()
    {
        Movement();
        lifeText.text = "X " + life;

        if (life == 0) 
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    void Movement() // Movimentação e troca de lado
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            sr.flipX = true;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f) // pulo
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("Jumping", true);
        }
        else
        {
            anim.SetBool("Jumping", false); 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Acid"))
        {
            
            life--;
        }
        if (collision.gameObject.CompareTag("Laser"))
        {
            Debug.Log("Auch!");
            life--;
        }

        
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            anim.SetBool("BoxCollider", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            anim.SetBool("BoxCollider", false);
        }
    }
}
