using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    public Image timerBarImage;  // Reference to the Image component of the timer bar
    public RectTransform quickTimer;
    public float initialWidth;
    public float countdownDuration = 10f;  // Duration of the countdown in seconds

    private float timePast;  // Time remaining in the countdown
    public Boolean timeUp;

    void Start()
    {
        initialWidth = quickTimer.rect.width;  // Initial width of the bar; subtraction just to hid the corners
        //Debug.Log("initwidth" + initialWidth);
        //Debug.Log("init rect width" + timerBarImage.rectTransform.rect.width);
        timePast = 0;

        //timerBarImage.rectTransform.sizeDelta = new Vector2(initialWidth, timerBarImage.rectTransform.sizeDelta.y);
    }

    void Update()
    {
        if (!timeUp)
        {
            timePast += Time.deltaTime;

            // Resize the bar based on the remaining time
            //Debug.Log(timerBarImage.rectTransform.rect.width);
            float widthFactor = timePast / countdownDuration;
            //initialWidth* widthFactor
            timerBarImage.rectTransform.sizeDelta = new Vector2(-initialWidth * widthFactor, timerBarImage.rectTransform.sizeDelta.y);
            //Debug.Log(timerBarImage.rectTransform.rect.width);
        }

        // Check if the timer has finished
        if (timePast >= countdownDuration)
        {
            timeUp = true;
            // Perform any actions needed when the timer ends
            // (e.g., trigger events, change game state, etc.)
            //Debug.Log("Timer finished!");
        }
    }
}