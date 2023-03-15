using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody RB;

  //  GameObject Cam;

    public float MoveSpeed = 0.2f;
    public float JumpForce = 1000;

   // public float MouseSensitivity = 10;

    float Vertical;
    float Horizontal;

 //   public float MouseX;
//    public float MouseY;

    public bool IsGrounded;

  //  float CamRotX;

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
    //    MouseX = Input.GetAxis("Mouse X");
      //  MouseY = Input.GetAxis("Mouse Y");

        RB.MovePosition((transform.position + (transform.forward) * Vertical * MoveSpeed) + (transform.right * Horizontal * MoveSpeed));

        if (IsGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(transform.up * JumpForce);
        }

      //  RB.MoveRotation(RB.rotation * Quaternion.Euler(new Vector3(0, MouseX * MouseSensitivity, 0)));

     //   CamRotX -= MouseY * MouseSensitivity;
      //  CamRotX = Mathf.Clamp(CamRotX, -MaxRotX, MaxRotX);
      //  Quaternion CamRot = Quaternion.Euler(CamRotX, 0, 0);
      //  Cam.transform.localRotation = CamRot;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}