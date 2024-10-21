using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gta5 : MonoBehaviour
{

    public Rigidbody2D Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
        Player.velocity = new Vector3(0f, 100f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Player.velocity = new Vector3(100f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
            {
                Player.velocity = new Vector3(-100f, 0f, 0f);
            }
        }
}
