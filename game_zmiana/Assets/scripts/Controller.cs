using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5f;
    public AudioSource audioSource;
    //  public isgrounded groundedCheck;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //    if (groundedCheck.IsGrounded())
        //   {
        transform.Translate(new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime);
        audioSource.Play();
        //   }
    }
}