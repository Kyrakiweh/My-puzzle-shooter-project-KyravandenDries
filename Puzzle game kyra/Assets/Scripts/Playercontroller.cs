using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    public float movespeed = 15;
    public GameObject bulletPrefab;
    public Camera playerCamera;
    private Vector3 moveDirection;

    
    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        
    }
	
	// Update is called once per frame
	void Update () {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
      
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;
        }
            
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection));
    }
}
