using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Player attributes
    public float speed;
    public float jumpForce;

    public Rigidbody2D rigigBody;

    float direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpPlayer();
    }

    void FixedUpdate()
    {
        moviePlayer();
        
    }

    void moviePlayer()
    {
        direction = Input.GetAxis("Horizontal");

        rigigBody.velocity = new Vector2(direction * speed,rigigBody.velocity.y);
    }

    void jumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigigBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
