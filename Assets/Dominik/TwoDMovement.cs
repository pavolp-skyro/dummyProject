using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TwoDMovement : MonoBehaviour
{
    [SerializeField] Transform m_Camera;
    Rigidbody rb;
    float xInput;
    float zInput;
    float sped = 5f;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         xInput = Input.GetAxisRaw("Horizontal");
         zInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        // rb.velocity = new Vector3(xInput, 0, yInput).normalized * sped;
        Vector3 directionZ = m_Camera.forward;
        Vector3 directionX = m_Camera.right;
        Vector3 FlatdirectionZ = new Vector3(directionZ.x, 0, directionZ.z);
        Vector3 FlatdirectionX = new Vector3(directionX.x, 0, directionX.z);
        rb.linearVelocity = (FlatdirectionZ* zInput + FlatdirectionX * xInput).normalized * sped;
    }
}
