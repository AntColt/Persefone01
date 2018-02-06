using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public bool isOnGround = true;

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ground")
        {
            this.isOnGround = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            this.isOnGround = true;
        }
    }
}
