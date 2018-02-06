using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCheckpoint : MonoBehaviour {
    
    [SerializeField] GameObject checkPoint;
    private void Start()
    {
        
    }

    void Update () {

        if (Input.GetKeyDown(KeyCode.P))
        {
            Destroy(GameObject.FindGameObjectWithTag("Checkpoint"));
            Instantiate(checkPoint, transform.position, transform.rotation);
        }
	}
}
