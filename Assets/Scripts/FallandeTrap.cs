using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallandeTrap : MonoBehaviour {

    Rigidbody m_Rigidbody;

    float startPositionfloat;
    Vector3 startPosition;

    void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
    }

    private void Awake()
    {
        startPosition = transform.position;
    }

    [SerializeField] float disctanceAboveGround;
    void FixedUpdate () {
        float y = transform.position.y;
        if (y < startPosition.y - disctanceAboveGround)
        {
            transform.position = startPosition;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            m_Rigidbody.constraints = RigidbodyConstraints.None;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
        }
    }
}
