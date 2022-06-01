using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Muncul: MonoBehaviour
{
    public abstract IEnumerator Summon();

} 

public class MunculinVirus : Muncul
{
    public GameObject virus;
    public float waktuMin, waktuMax;
    public float posisiMin, posisiMax;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Summon());
    }

    public override IEnumerator Summon()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMin,posisiMax), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMin, waktuMax));
        StartCoroutine(Summon());
    }
}

public class MunculObat: Muncul
{
    public GameObject obat;
    public float waktuMin, waktuMax;
    public float posisiMin, posisiMax;
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(Summon());
    }

    public override IEnumerator Summon()
    {
        Instantiate(obat, transform.position + Vector3.right * Random.Range(posisiMin, posisiMax), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMin, waktuMax));
        StartCoroutine(Summon());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
        }
    }
}



