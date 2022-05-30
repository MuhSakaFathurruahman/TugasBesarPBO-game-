using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    [SerializeField] Slider HealthBar;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            TakeDamage();
        }
    }
    /*
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("virus"))
        {
            TakeDamage();
        }
    }*/

    public void TakeDamage()
    {
        health -= 1;
    }

    private void Update()
    {
        HealthBar.value = health;

        if (health <= 0)
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
