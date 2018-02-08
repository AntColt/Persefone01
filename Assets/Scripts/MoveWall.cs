using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour {

    static MoveWall moveWall;
    public static MoveWall GetMoveWall() { return moveWall; }

    void Start()
    {
        moveWall = this;
    }

    [SerializeField] float moveSpeed;
    void Update() {
        transform.Translate(0, moveSpeed, 0);
    }

    public void Move(Vector3 pos)
    {
        float f = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
        if (f < 1)
            f = 5;
        transform.position = new Vector3(pos.x - f, transform.position.y, transform.position.z);

    }
}
