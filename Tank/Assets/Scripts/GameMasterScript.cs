using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour {

    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject GameOverUI;
    public GameObject WinUI;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Enemy1 = GameObject.Find("Enemy1");
        Enemy2 = GameObject.Find("Enemy2");
        Enemy3 = GameObject.Find("Enemy3");
        Enemy4 = GameObject.Find("Enemy4");
        Enemy5 = GameObject.Find("Enemy5");

    }
	
	// Update is called once per frame
	void Update () {
	    if (Player == null)
        {
            GameOverUI.SetActive(true);
        }	

        if (Enemy1 == null && Enemy2 == null && Enemy3 == null && Enemy4 == null && Enemy5 == null)
        {
            WinUI.SetActive(true);
        }
	}
}
