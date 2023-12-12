using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Range(0, .3f)][SerializeField] private float m_MovementSmoothing = .05f;
    private Rigidbody2D rb;
    [SerializeField] float speed, jumpStrength;
    private Vector3 m_Velocity = Vector3.zero;
    bool freeMove;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Move(Vector2 move, bool jump)
    {
        Vector3 targetVelocity = new Vector2(move.x * 10f, rb.velocity.y); ;
        if (freeMove)
        {
            targetVelocity.y = move.y * 10f;
        }
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        if (jump)
        {
            rb.AddForce(new Vector2(0f, jumpStrength));
        }
    }
    private void FixedUpdate()
    {
        
    }
}
