using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIHealth : MonoBehaviour
{
    int currentHealth;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player)
        {
            Health healthComp = player.GetComponent<Health>();
            if (healthComp)
            {
                currentHealth = healthComp.GetHealth();
            }
        }
    }

    /// <summary>
    /// Callback for HealthChangeEvent in Health component.
    /// </summary>
    /// <param name="health">New health after a change (damage or heal).</param>
    public void OnHealthChange(int health)
    {
        currentHealth = health;
    }
}
