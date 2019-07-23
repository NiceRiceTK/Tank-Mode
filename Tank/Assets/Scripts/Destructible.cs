using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {
    public float health = 100;
    public GameObject Explosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(float Damage)
    {
        health -= Damage;
        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
