using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractors : MonoBehaviour {

    const float G = 667.4f;

    public static List<Attractors> attractors;

    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        foreach(Attractors attractor in attractors)
        {
            if(attractor != this)
            {
                attract(attractor);
            }
            
        }
    }

    private void OnEnable()
    {
        if(attractors == null)
        {
            attractors = new List<Attractors>();
        }

        attractors.Add(this);

    }

    private void OnDisable()
    {
        attractors.Remove(this);
    }

    public void attract(Attractors attractor)
    {
        Rigidbody2D attractTo = attractor.rb;

        Vector2 direction = rb.position - attractTo.position;
        float distance = direction.magnitude;

        float forceMagnitude = (rb.mass * attractTo.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude;

        attractTo.AddForce(force);
    }
}
