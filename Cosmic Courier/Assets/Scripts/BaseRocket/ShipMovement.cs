using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    public float maxDeacceleration = 1f;
    private Rigidbody2D rb;
    private Animator anim;

    private float accelerate;
    private float rotation;

    void Start()
    {
	    rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        accelerate = Mathf.Clamp(Input.GetAxis("Vertical"), -maxDeacceleration, 1f);
        rotation = Input.GetAxis("Horizontal");

        //Animation
        anim.SetFloat("Acceleration" , accelerate);
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.up * accelerate * moveSpeed * Time.fixedDeltaTime);
        transform.Rotate(Vector3.forward, rotation * rotationSpeed * Time.fixedDeltaTime);
    }

}