using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
    
{
   [SerializeField] private float speed;
    void Update()
    {
        if (gameObject.GetComponentInChildren<GroundCheck>().GetComponent<GroundCheck>().isOnGround == true)
        {
            this.transform.Translate(-speed, 0, 0);
        }
        if (gameObject.GetComponentInChildren<GroundCheck>().GetComponent<GroundCheck>().isOnGround == false)
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * 10588, 23529411765f);
            this.transform.Rotate(Vector3.up * Time.deltaTime * 10588, 23529411765f);
        }
        if (gameObject.GetComponentInChildren<InFrontCheck>().GetComponent<InFrontCheck>().isHittingSomething == true)
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * 10588, 23529411765f);
            this.transform.Rotate(Vector3.up * Time.deltaTime * 10588, 23529411765f);
        }
    }
}

