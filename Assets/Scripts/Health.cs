using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private float hp;

    public float maxHealth = 100f;

    [Header("Events")]
    public UnityEvent<float, float> onDamage;
    public UnityEvent onDeath;


    private void Start()
    {
        hp = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        hp = hp < 0 ? 0 : hp;
        onDamage.Invoke(hp, damage);

        if (hp <= 0)
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
    }
}
