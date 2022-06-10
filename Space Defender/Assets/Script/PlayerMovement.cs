using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public Vector2 movement;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   private void OnMovement(InputValue value)
    {
      movement = value.Get<Vector2>();
    }
  
    private void FixedUpdate()
    {
     rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}
