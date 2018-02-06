using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelmanager;

	void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
	}
	


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            levelmanager.RespawnPlayer();
        }
        if (other.tag == "Doll")
        {
            Destroy(other.gameObject);
        }
    }
}
