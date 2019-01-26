using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;
    [SerializeField]Transform planetTransform;
    float radius;
    Vector2 desiredPos;
    float a;
    [SerializeField] float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        radius = 1;
            //Vector2.Distance(transform.position, planetTransform.position);
    }

    private void Update()
    {
        
        
        desiredPos = new Vector2(Mathf.Cos(a) + planetTransform.position.x,Mathf.Sin(a) + planetTransform.position.y);

        a += speed;
        rb.MovePosition(desiredPos);
    }

}
