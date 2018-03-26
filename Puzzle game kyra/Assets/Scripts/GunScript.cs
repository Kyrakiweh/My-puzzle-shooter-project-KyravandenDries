using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
	}
    void Shoot()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.name);

            EnemyScript target = hitInfo.transform.GetComponent<EnemyScript>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }

    }
}
