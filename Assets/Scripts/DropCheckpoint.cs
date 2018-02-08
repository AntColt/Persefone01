using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCheckpoint : MonoBehaviour {
    
    [SerializeField] GameObject checkPoint;
    [SerializeField] GameObject spawnCheckpoint;
    private void Start()
    {
        
    }

    [SerializeField] float lightToRemove;
    void Update () {

        if (Input.GetKeyDown(KeyCode.P))
        {
            Destroy(GameObject.FindGameObjectWithTag("Checkpoint"));
            Instantiate(checkPoint, spawnCheckpoint.transform.position, spawnCheckpoint.transform.rotation);
            FindObjectOfType<LightIntensity>().GetComponent<LightIntensity>().SetLightRange(lightToRemove);
        }
	}
}
