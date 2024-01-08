using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : MonoBehaviour
{
    public SpriteRenderer squidRenderer;
    public float colorChangeSpeed = 0.1f;  // Adjust this to control the change speed

    private Color originalColor = Color.white;
    private Color targetColor = Color.red;

    float t = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(EventManager.isPlayerTouchingRocks);
        if (!EventManager.isPlayerTouchingRocks)
        {
            Debug.Log("changing color");
            // Gradually change color here
            t += colorChangeSpeed * Time.deltaTime;
            squidRenderer.color = Color.Lerp(originalColor, targetColor, t);
            //yield return null;
        }
    }

}
