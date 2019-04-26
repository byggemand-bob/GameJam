using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float bulletVelocity = 20;

    // Start is called before the first frame update
    void Start() {
        rb2D = GetComponent<Rigidbody2D>(); 

    }

    // Update is called once per frame
    void FixedUpdate() {
        rb2D.velocity = transform.forward * bulletVelocity;
    }
}
