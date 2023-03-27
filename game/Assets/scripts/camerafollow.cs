using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Quaternion my_rotation;
    void Start()
    {
        my_rotation = this.transform.rotation;
    }
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position+offset;
        Vector3 smoothedPositon = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPositon;
        transform.LookAt(target);
        this.transform.rotation = my_rotation;
    }

}
