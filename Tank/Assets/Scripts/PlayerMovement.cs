using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private Rigidbody2D playerRigidBody;
    private Vector3 change;
    private Animator PlayerAnim;
    public GameObject shell;
    public float health = 100;
    public GameObject Explosion;

    // Use this for initialization
    void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
        PlayerAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position.x += 0.6f;
            //Shoot Right
            GameObject go = (GameObject)Instantiate(shell, position, Quaternion.identity);
            go.GetComponent<ShellController>().xspeed = 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position.y += 0.6f;
            //Shoot Up
            GameObject go = (GameObject)Instantiate(shell, position, Quaternion.identity);
            go.GetComponent<ShellController>().yspeed = 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.x += -0.6f;
            //Shoot Left
            GameObject go = (GameObject)Instantiate(shell, position, Quaternion.identity);
            go.GetComponent<ShellController>().xspeed = -0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position.y += -0.6f;
            //Shoot Down
            GameObject go = (GameObject)Instantiate(shell, position, Quaternion.identity);
            go.GetComponent<ShellController>().yspeed = -0.1f;
        }
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MovePlayer();
            PlayerAnim.SetFloat("moveX", change.x);
            PlayerAnim.SetFloat("moveY", change.y);
            PlayerAnim.SetBool("Moving", true);
        }
        else
        {
            PlayerAnim.SetBool("Moving", false);
        }
    }

    void MovePlayer()
    {
        playerRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime);
    }

    public void PlayerTakeDamage(float Damage)
    {
        health -= Damage;
        if (health <= 0)
        {
            PlayerDie();
        }

    }
    void PlayerDie()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
