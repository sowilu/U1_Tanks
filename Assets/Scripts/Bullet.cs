using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;

    public float speed = 20;
    public float lifeTime = 5;

    public float maxDamage = 10;
    public float minDamage = 5;

    private void Start()
    {
        Invoke(nameof(Explode), lifeTime);
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
        Explode();
    }

    void Explode()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
