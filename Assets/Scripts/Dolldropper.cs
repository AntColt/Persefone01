using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolldropper : MonoBehaviour {
    public GameObject dollPrefab;
    public Transform dollSpawn;
	// Use this for initialization
	void Start () {
       
            InvokeRepeating("Fire", 2.0f, 4f);
    }
	
	
    void Fire()
    {
        
        var bullet = (GameObject)Instantiate(
            dollPrefab,
            dollSpawn.position,
            dollSpawn.rotation);

       
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 7;

       
        Destroy(bullet, 3.5f);
    }
}
