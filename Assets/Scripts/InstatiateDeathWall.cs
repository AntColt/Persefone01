using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateDeathWall : MonoBehaviour {
    [SerializeField] GameObject deathWall;
    [SerializeField] GameObject spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && GameObject.FindGameObjectWithTag("DeathWall") == null)
        {
            Instantiate(deathWall, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
    }
}
