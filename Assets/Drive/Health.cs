using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// Contains the player's current health as an integer.
/// </summary>
[System.Serializable]
public class HealthChangeEvent : UnityEvent<int> { }


/// <summary>
/// Triggers when the GameObject dies.
/// </summary>
[System.Serializable]
public class DeathEvent : UnityEvent { }



public class Health : MonoBehaviour
{
    [SerializeField]
    private int health;
    public int GetHealth() { return health; }

    [SerializeField]
    [Header("Contains the GameObject's new health after a change.")]
    private HealthChangeEvent healthChangeListeners;

    [SerializeField]
    [Header("What happens when this GameObject dies?")]
    private DeathEvent deathListeners;


    public void Heal(int amount)
    {
        ChangeHealth(amount);
    }

    public void Damage(int amount)
    {
        ChangeHealth(-amount);
    }


    private void ChangeHealth(int amount)
    {
        health += amount;
        healthChangeListeners.Invoke(health);

        if (health <= 0)
        {
            deathListeners.Invoke();
        }
    }
}
