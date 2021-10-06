using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{



    public Rigidbody2D rb;
    private float moveSpeed;

    public Joystick joystick;

    float horizontalMove = 0f;

    //float h;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 15f;

    }

    private void Update()
    {
        // h = Input.GetAxis("Horizontal") * moveSpeed;
        //this.transform.Translate(h * Time.deltaTime, 0, 0);


        horizontalMove = joystick.Horizontal * moveSpeed;
        this.transform.Translate(horizontalMove * Time.deltaTime, 0, 0);




    }


    
}
