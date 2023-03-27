using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isgrounded : MonoBehaviour
{
    private bool isGrounded;

    private void OnTriggerEnter(Collider other)
    {
        isGrounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
}
