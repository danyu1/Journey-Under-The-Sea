using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("debug logger");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("debug logger");
    }

    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            EventManager.isPlayerTouchingRocks = true;
            Debug.Log("2d trigger");
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {

            EventManager.isPlayerTouchingRocks = true;
            Debug.Log("2d trigger stay");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            EventManager.isPlayerTouchingRocks = false;
            Debug.Log("exit");
        }
    }

}
