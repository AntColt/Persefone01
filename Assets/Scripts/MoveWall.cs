using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour {

    [SerializeField] float moveSpeed;
	void Update () {
        transform.Translate(0, moveSpeed, 0);
	}
}
