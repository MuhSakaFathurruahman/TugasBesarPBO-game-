using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPlayer : MonoBehaviour
{
    public float kecepatan; // Untuk Putaran
    Rigidbody rigidbody; // Untuk gerak Player
    Animator anim; // Untuk gerakan Animasi

    public Transform playerPutaran; // Untuk putaran Objek

    private void Awake() // Awake untuk mendahului start
    {
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate() // Instansiasi method bergerak
    {
        Bergerak(); // Ini instansiasinya
    }

    void Bergerak() // Method untuk bergerak
    {
        float gerak = Input.GetAxis("Horizontal");
        rigidbody.velocity = Vector3.right * gerak * kecepatan;
        anim.SetFloat("Kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3(0, gerak * 90, 0);
    }

    /*private void Update()
    {
        HealthBar.value = health;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        health -= 1;
    }*/
}
