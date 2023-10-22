using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public float lifeTime = 5;

    public float maxDamage = 10;
    public float minDamage = 5;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null)
        {
            var damage = Random.Range(minDamage, maxDamage + 1);
            health.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
