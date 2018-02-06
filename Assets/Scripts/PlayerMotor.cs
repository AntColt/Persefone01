using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    //controllers

    MeshRenderer meshRenderer;

    enum JumpState { NONE, JUMP, DOUBLEJUMP }
    [SerializeField ] JumpState currentJumpState = JumpState.NONE;

    private Rigidbody rigidBody;
    private BoxCollider boxCollider;
    //floats
    [SerializeField]private float verticalVelocity;
    private float VerticalVelocity
    {
        get { return verticalVelocity; }
        set { verticalVelocity = value > 20 ? 20 : value < -20 ? -20 : value; }
    }

    [SerializeField] bool isGrounded;
    bool IsGrounded
    {
        get { return isGrounded; }
        set
        {
            isGrounded = value;
        }
    }

    private float gravity = 12.0f;
    private float jumpForce = 6.5f;
    [SerializeField] private float jumper = 0f;
    [SerializeField] private int allowedJumps = 1;

    //bools
   

	void Start () {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }
    void Update()
    {
        if (!IsGrounded)
        {
            if(currentJumpState == JumpState.NONE)
            {
                currentJumpState = JumpState.JUMP;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    private void LateUpdate()
    {
        float jumpForgiveness = 2;
        VerticalVelocity -= gravity * Time.deltaTime;
        Debug.Log((gravity * Time.deltaTime));
        if (verticalVelocity < -(gravity * Time.deltaTime * jumpForgiveness))
        {
            IsGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        Vector3 moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * 4.0f;
        moveVector.y = VerticalVelocity;
        rigidBody.velocity = moveVector;
    }

    void Jump()
    {
        Debug.Log("Jump");
        switch(currentJumpState)
        {
            case JumpState.NONE:
                if (IsGrounded)
                {
                    IsGrounded = false;
                    VerticalVelocity = jumpForce;
                    currentJumpState = JumpState.JUMP;
                }
                break;
            case JumpState.JUMP:
                VerticalVelocity = jumpForce;
                currentJumpState = JumpState.DOUBLEJUMP;
                break;

        }
    }


    void GetGrounded()
    {
        currentJumpState = JumpState.NONE;
        IsGrounded = true;
        VerticalVelocity = 0;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colliding");
        if (!IsGrounded)
        {
            rigidBody.velocity = new Vector3(0, rigidBody.velocity.y);
        }
        if (collision.gameObject.tag == "Ground")
        {
            if (collision.collider.bounds.max.y >= boxCollider.bounds.min.y && collision.collider.bounds.max.y - boxCollider.bounds.min.y < Time.deltaTime)
            {
                Debug.Log("Getting grounded");
                if (!IsGrounded)
                {
                    GetGrounded();
                }
                if (VerticalVelocity < 0)
                {
                    VerticalVelocity = 0;
                }
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (!IsGrounded)
            {
                //rigidBody.velocity = new Vector3(0, rigidBody.velocity.y);
            }
            Debug.Log("Colliding (Stay)");
            if (collision.collider.bounds.max.y >= boxCollider.bounds.min.y && collision.collider.bounds.max.y - boxCollider.bounds.min.y < Time.deltaTime)
            {
                Debug.Log("Getting grounded");
                if (!IsGrounded)
                {
                    GetGrounded();
                }
                if(VerticalVelocity < 0)
                {
                    VerticalVelocity = 0;
                }
            }
        }
    }
}
