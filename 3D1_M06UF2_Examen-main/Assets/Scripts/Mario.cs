using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public Rigidbody2D rBody;

    public float movementSpeed = 15;
    public float jumpforce = 5;
    private float inputHorizontal;
    public SpriteRenderer render;
    public Vector3 newPosition = new Vector3(50, 5, 0);
                    
                    
    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");

        if(inputHorizontal < 0)
        {
            render.flipX = true;
        }
        
        else if(inputHorizontal > 0)
        {
            render.flipX = false;
        }
    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }
}
