
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Collider2D collider1;
    public Collider2D collider2;
    bool uiUp;
    private void Awake()
    {
        uiUp = false;
    }
    void Update()
    {
        if (collider1 != null && collider2 != null)
        {
            //if (Input.GetButtonDown("Submit"))
            //{
            //    //Debug.Log("PopUpUI");
            //}
            if (collider1.bounds.Intersects(collider2.bounds) && Input.GetButtonDown("Submit"))
            {
                Debug.Log("PopUpUI");
                uiUp = true;
            }
            else
            {
                uiUp = false;
                
            }
        }
        else
        {
            Debug.LogWarning("Ensure both colliders are assigned.");
        }
    }
}