using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRb;
    //Step 3.3
    //void Start()
    //{
    //    playerRb = GetComponent<Rigidbody>();
    //    playerRb.AddForce(Vector3.up * 1000);
    //}

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * 100 , ForceMode.Impulse);
        }
    }
}
