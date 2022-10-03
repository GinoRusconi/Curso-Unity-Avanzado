using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoFPS : MonoBehaviour
{
    public float distanceToRaycast = 10f;
    public float timeBetweenShoot = 1f;
    public LayerMask damagableLayer;
    private float nextTimeShoot = 0f;

    void Start()
    {
        nextTimeShoot = Time.time;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") )
        {
            //nextTimeShoot += timeBetweenShoot;
            Debug.Log("Shooting");
            ShootRayCast();
        }     
    }

    private void ShootRayCast()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,distanceToRaycast,damagableLayer);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceToRaycast, Color.red);
        Debug.Log(hit.transform.gameObject.name);
    }
}
