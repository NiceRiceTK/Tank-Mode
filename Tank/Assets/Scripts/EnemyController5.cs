using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController5 : MonoBehaviour {

    public float speed = 2f;
    private Transform target;
    private int wavepointIndex = 0;
    public float health = 100;
    public GameObject Explosion;


    // Use this for initialization
    void Start()
    {
        target = Waypoint5.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }

    }

    void GetNextWayPoint()
    {
        if (wavepointIndex >= Waypoint5.points.Length - 1)
        {

            wavepointIndex = 0;
            target = Waypoint5.points[wavepointIndex];
            return;
        }
        else
        {
            wavepointIndex++;
            target = Waypoint5.points[wavepointIndex];
        }
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
