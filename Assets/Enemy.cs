using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Color hurtColor = Color.red;

    [SerializeField]
    float hurtEffectDuration, hurtEffectMaxLerp;

    Health health;
    Material mat;

    bool isDead;

    private void Awake()
    {
        health = GetComponent<Health>();
        mat = GetComponent<SpriteRenderer>().material;

        isDead = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return;

        if (collision.CompareTag("Bullet"))
        {
            health.Damage(1);
            StartCoroutine(HurtEffect());
        }
    }


    public void OnDeath()
    {
        print("DEAD");
        isDead = true;
    }


    IEnumerator HurtEffect()
    {
        float timer = 0f;
        float lerp = hurtEffectMaxLerp;

        while (timer < hurtEffectDuration)
        {
            timer += Time.deltaTime;
            lerp = hurtEffectMaxLerp * (1 - (timer / hurtEffectDuration));
            print(lerp);

            mat.color = Color.Lerp(Color.white, hurtColor, lerp);
        }

        yield return null;
    }
}
