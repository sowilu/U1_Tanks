using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform bar;

    public void SetSize(float health, float damage)
    {
        bar.localScale = new Vector3(health / 100, 1f);
    }
}
