using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InFrontCheck : MonoBehaviour {

    public bool isHittingSomething = false;

    private void Start()
    {
        isHittingSomething = false;
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.tag != "Player")
        {
            this.isHittingSomething = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag != "Player")
        {
            this.isHittingSomething = true;
            Debug.Log("AJ");
        }
    }
}
