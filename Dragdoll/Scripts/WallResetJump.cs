﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallResetJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Body")
        {
            collision.transform.parent.GetComponent<RagdollMovement>().canJump = true;
            Debug.Log("Jump Reset!");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Body")
        {
            collision.transform.parent.GetComponent<RagdollMovement>().canJump = true;
            Debug.Log("Jump Reset!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Body")
        {
            collision.transform.parent.GetComponent<RagdollMovement>().canJump = false;
            Debug.Log("Jump Disabled");
        }
    }
}
