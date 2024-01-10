using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class Page10Squid : MonoBehaviour
{
    public Camera mainCamera;  // Reference to the main camera
    public float speed = 5f;    // Speed of the sprite's movement
    public float maxScale = 10f; // Maximum scaling factor for the sprite
    public float midlineTolerance = 50f; // Tolerance for mouse distance from midline

    void Update()
    {
        // Get the mouse position in world space
        Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        //// Calculate the distance between the mouse and the sprite
        //float distance = Vector2.Distance(transform.position, mouseWorldPos);

        // Calculate the distance between the mouse and the midline
        float mouseMidlineDistance = Mathf.Abs(mouseWorldPos.x - transform.position.x);
        Debug.Log(mouseMidlineDistance);

        // scale the sprite based on the distance
        float scaleFactor = Mathf.Clamp01(1 - mouseMidlineDistance / midlineTolerance) * maxScale;
        transform.localScale = Vector3.one * scaleFactor;
        //float scaleFactor = Mathf.Clamp01(distance / Screen.width) * maxScale;
        //Debug.Log(distance);
        //float scaleFactor = distance * maxScale;
        //transform.localScale = Vector3.one * scaleFactor;
    }
}
