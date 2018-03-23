using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    public float movespeed = 15;
    private Vector3 movedir;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        movedir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

	}
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + Transform.TransformDirection()
    }
}
