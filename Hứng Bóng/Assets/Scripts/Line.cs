using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDir = Input.GetAxisRaw("Horizontal");

        float moveStep= moveSpeed* Time.deltaTime*xDir ;


        if ((transform.position.x <= -8f && xDir < 0) || (transform.position.x >= 8f && xDir > 0))
            return;

        transform.position += new Vector3(moveStep,0,0) ;
        
    }
}
