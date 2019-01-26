using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity2D : MonoBehaviour {

    Rigidbody2D rb;
    [SerializeField]Rigidbody2D rb2;
    Vector2 desiredVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        Vector2 direction = rb2.position - rb.position;
        float distance = direction.magnitude;

        float forceMagnitude = (rb.mass * rb2.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude * 655;

        rb.AddForce(force);
    }

   //public void attract(Rigidbody2D attractor)
   //{
   //    Rigidbody2D attractTo = attractor;
   //
   //    Vector2 direction = rb.position - attractTo.position;
   //    float distance = direction.magnitude;
   //
   //    float forceMagnitude = (rb.mass * attractTo.mass) / Mathf.Pow(distance, 2);
   //    Vector2 force = direction.normalized * forceMagnitude;
   //
   //    rb.AddForce(force);
   //}
}
