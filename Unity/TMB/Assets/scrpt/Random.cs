using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour {
    public Rigidbody2D rb;
    public float thrust;
	// Use this for initialization
	void Start () {
        rb.GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(25000, 25000);
        rb.AddForce(movement);
    }

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update () {

    }
}
