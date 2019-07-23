using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour {
    public float xspeed = 0f;
    public float yspeed = 0f;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        StartCoroutine(DespawnShell());
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.x += xspeed;
        position.y += yspeed;
        transform.position = position;
	}

    IEnumerator DespawnShell()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        EnemyController enemy = col.GetComponent<EnemyController>();
        EnemyController1 enemy1 = col.GetComponent<EnemyController1>();
        EnemyController3 enemy3 = col.GetComponent<EnemyController3>();
        EnemyController4 enemy4 = col.GetComponent<EnemyController4>();
        EnemyController5 enemy5 = col.GetComponent<EnemyController5>();
        Destructible des = col.GetComponent<Destructible>();
        if (enemy != null)
        {
            enemy.TakeDamage(40);
        }
        else if (enemy1 != null)
        {
            enemy1.TakeDamage(40);
        }
        else if (enemy3 != null)
        {
            enemy3.TakeDamage(40);

        }
        else if (enemy4 != null)
        {
            enemy4.TakeDamage(40);
        }
        else if (enemy5 != null)
        {
            enemy5.TakeDamage(40);
        }
        else if (des != null)
        {
            des.TakeDamage(40);
        }
        Destroy(gameObject);
    }
}
