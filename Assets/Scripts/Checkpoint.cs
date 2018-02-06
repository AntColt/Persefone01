using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public LevelManager levelmanager;

    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

 
    void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            levelmanager.currentCheckpoint = gameObject;
        }
    }
}
