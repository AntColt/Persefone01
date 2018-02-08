using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour {


    Animator animator;
    PlayerMotor playermotor;
	void Start () {
        animator = GetComponent<Animator>();
        playermotor = gameObject.GetComponentInParent<PlayerMotor>();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateAnimator();
        if (playermotor.GetIsFacingRight())
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (!playermotor.GetIsFacingRight())
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void UpdateAnimator()
    {
        animator.SetBool("isGrounded", playermotor.GetIsGrounded());
        Debug.Log(playermotor.GetIsGrounded());
        if (Input.GetButton("Jump"))
        {
            animator.SetTrigger("Jump");
        }

        if(playermotor.GetMoveVector() < 0 || playermotor.GetMoveVector() > 0)
        {
            animator.SetBool("isRunning", true);
        }
        else if(playermotor.GetMoveVector() == 0)
        {
            animator.SetBool("isRunning", false);
        }
        if(playermotor.GetIsGrounded())
        {
            animator.SetBool("isGrounded", true);
        }
        else
            animator.SetBool("isGrounded", false);
    }
}
