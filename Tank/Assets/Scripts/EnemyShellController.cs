using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShellController : MonoBehaviour {
    public float xspeed = 0f;
    public float yspeed = 0f;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(DespawnShell());
    }

    // Update is called once per frame
    void Update()
    {
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
        PlayerMovement player = col.GetComponent<PlayerMovement>();
        if (player != null)
        {
            player.PlayerTakeDamage(20);
        }
        Destroy(gameObject);
    }
}
