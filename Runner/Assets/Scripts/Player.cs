using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameController m_gc;
    public float jumpForce;
    Rigidbody2D m_rb;
    bool m_isGrounded;

    public AudioSource aus;
    public AudioClip jumbSound;
    public AudioClip loseSound;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();  
        m_gc = FindAnyObjectByType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJumpKeyPressed = Input.GetKeyDown(KeyCode.Space);
        if (isJumpKeyPressed && m_isGrounded) {
            m_rb.AddForceY(jumpForce);
            m_isGrounded = false;

            if (aus && jumbSound ) {
                aus.PlayOneShot(jumbSound);            
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            m_isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle")){

            m_gc.SetGameoverState(true);

            if (aus && loseSound)
            {
                aus.PlayOneShot(loseSound);
            }

            Debug.Log("Da va cham voi Obstacle");
        }
    }






}
