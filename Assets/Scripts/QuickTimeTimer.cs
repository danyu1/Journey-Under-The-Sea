using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeTimer : MonoBehaviour
{
    public RectTransform timerBarImage;  // Reference to the Image component of the timer bar
    public float initialWidth = 200f;  // Initial width of the bar
    public float countdownDuration = 10f;  // Duration of the countdown in seconds

    private float timeRemaining;  // Time remaining in the countdown

    void Start()
    {
        timeRemaining = countdownDuration;
        timerBarImage.sizeDelta = new Vector2(initialWidth, timerBarImage.sizeDelta.y);
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        // Resize the bar based on the remaining time
        float widthFactor = timeRemaining / countdownDuration;
        timerBarImage.sizeDelta = new Vector2(initialWidth * widthFactor, timerBarImage.sizeDelta.y);

        // Check if the timer has finished
        if (timeRemaining <= 0f)
        {
            // Perform any actions needed when the timer ends
            // (e.g., trigger events, change game state, etc.)
            Debug.Log("Timer finished!");
        }
    }
}
