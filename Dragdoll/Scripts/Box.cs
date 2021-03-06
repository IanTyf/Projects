﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
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
            GameObject[] starFollows = GameObject.FindGameObjectsWithTag("StarFollow");
            foreach (GameObject star in starFollows)
            {
                if (star.GetComponent<StarFollow>().ObjToFollow != null)
                {
                    star.GetComponent<StarFollow>().flyToBox(transform.position);
                }
            }
        }
    }
}
