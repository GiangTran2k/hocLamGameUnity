using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    GameController m_gc;
    public float moveSpeed =3f;
    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindAnyObjectByType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -13f)
        {
            m_gc.IncrementScore();
            Destroy(gameObject);
        }

       
    }

    
}
