using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindAnyObjectByType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            m_gc.InCrementScore();
            Debug.Log("Qua bong da va cham voi Player");
            Destroy(gameObject);
        }

        else if (collision.CompareTag("DeathZone"))
        {
            m_gc.SetGameoverState(true);
            Debug.Log("Qua bong da va cham voi DeathZone");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
    
}
