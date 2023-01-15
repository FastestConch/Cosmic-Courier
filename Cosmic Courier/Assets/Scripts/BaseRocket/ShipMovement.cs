using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    private Rigidbody2D rb;
    private Animator anim;

    Vector2 movement = Vector2.zero;

    void Start()
    {
	  rb = gameObject.GetComponent<Rigidbody2D>();

      anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
 
        //Animation
        anim.SetFloat("ForwardAcceleration" , movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
        rb.AddForce(transform.up * moveSpeed * Time.fixedDeltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
        rb.AddForce(transform.up * -moveSpeed * Time.fixedDeltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.fixedDeltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.fixedDeltaTime);
        }
    }

}