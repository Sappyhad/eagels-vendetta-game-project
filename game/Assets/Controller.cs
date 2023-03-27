using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody RB;

  //  GameObject Cam;

    public float MoveSpeed = 0.2f;
    public float JumpForce = 1000;


    float Vertical;
    float Horizontal;


    public bool IsGrounded;

    float CamRotX;

    public float MaxRotX;

    void Awake()
    {
        RB = GetComponent<Rigidbody>();
       // Cam = transform.Find("Camera").gameObject;
    }

    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");

        RB.MovePosition((transform.position + (transform.forward) * Vertical * MoveSpeed) + (transform.right * Horizontal * MoveSpeed));

        if (IsGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(transform.up * JumpForce);
        }

        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

}