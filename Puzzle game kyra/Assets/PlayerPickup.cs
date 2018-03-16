using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private GameObject UppickedObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            {
                if (UppickedObject == null)

                {
                    int layer = LayerMask.NameToLayer("PickUpLayer");
                    RaycastHit hitInfo;
                    if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo, 3.0f, 1 << layer))
                    {
                        UppickedObject = hitInfo.collider.gameObject;
                        UppickedObject.transform.parent = transform;

                        ((Rigidbody)UppickedObject.GetComponent(typeof(Rigidbody))).isKinematic = true;

                    }
                }
                else
                {
                    ((Rigidbody)UppickedObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
                    UppickedObject.transform.parent = null;
                    UppickedObject = null;
                }

            }
        }
    }
}
