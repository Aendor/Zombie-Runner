using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            print($"I hit this thing: {hit.transform.name} for {damage} damage.");
            //TODO: Add some viuals
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) { return; }

            // Call method on enemy health
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }

    }
}
