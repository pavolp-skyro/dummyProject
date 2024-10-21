using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCam : MonoBehaviour
{
    public Transform TeleportTo;
    float H_sped = 2f;
    float V_sped = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float h = H_sped * Input.GetAxis("Mouse X");
        float v = -V_sped * Input.GetAxis("Mouse Y");
        transform.Rotate(v,0 ,0);
        transform.Rotate(0, h, 0, Space.World);
        transform.position = TeleportTo.position;
    }
}
