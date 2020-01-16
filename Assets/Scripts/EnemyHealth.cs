using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    // public method decrease hp by amount of damage
    public void TakeDamage(float amount)
    {
        hitPoints -= amount;

        if (hitPoints <= 0)
        {
            Destroy(transform.gameObject);
        }
    }
}
