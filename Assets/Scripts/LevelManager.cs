using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;

    private PlayerMotor player;

	void Start ()
    {
        player = FindObjectOfType<PlayerMotor>();
	}
	
	
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
        MoveWall.GetMoveWall().Move(currentCheckpoint.transform.position);
    }
}
