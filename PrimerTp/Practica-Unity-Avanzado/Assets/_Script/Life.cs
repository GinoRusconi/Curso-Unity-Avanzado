using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float initLife;
    public float currentLife;

    void Start()
    {
        currentLife = initLife;    
    }
    public void TakeDamage(float takingDamage)
    {
        currentLife -= takingDamage;
    }
}
