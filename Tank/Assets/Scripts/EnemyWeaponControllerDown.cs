using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponControllerDown : MonoBehaviour {

    public float timerspeed = 2f;
    public float eleaspedtime;
    public GameObject Enemyshell;
    // Use this for initialization	
	void Update()
    {
        eleaspedtime += Time.deltaTime;
        if (eleaspedtime >= timerspeed)
        {
            Vector3 position = transform.position;
            GameObject go = (GameObject)Instantiate(Enemyshell, position, Quaternion.identity);
            go.GetComponent<EnemyShellController>().yspeed = -0.3f;
            eleaspedtime = 0f;
        }
    }
}
