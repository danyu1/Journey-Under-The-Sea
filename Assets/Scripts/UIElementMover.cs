using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;

public class UIElementMover : MonoBehaviour
{
    public Image uiElementToMove;  // Reference to the UI element you want to animate
    //public SpriteRenderer spriteToMove; // for testing purposes

    public float frequency = 1.0f;  // Controls how many cycles of the sine wave occur per second
    public float amplitude = 50.0f; // Controls the height of the sine wave's peaks and troughs

    private void Update()
    {
        // Calculate the current position based on the sine wave formula
        float time = Time.time;
        float yPos = Mathf.Sin(time * frequency * Mathf.PI * 2.0f) * amplitude;

        // Adjust the UI element's position
        uiElementToMove.rectTransform.anchoredPosition = new Vector2(uiElementToMove.rectTransform.anchoredPosition.x, yPos);
        //spriteToMove.transform.localPosition = new Vector3(spriteToMove.transform.localPosition.x, yPos, spriteToMove.transform.localPosition.z);
    }
}
