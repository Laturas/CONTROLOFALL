using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Direction;

public enum Direction {
    UP,
    DOWN,
    LEFT,
    RIGHT,
}

public class GP_Controller : MonoBehaviour
{
    public Transform character;
    public float moveAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {Move(UP); return;}
        if (Input.GetKeyDown(KeyCode.DownArrow)) {Move(DOWN); return;}
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {Move(LEFT); return;}
        if (Input.GetKeyDown(KeyCode.RightArrow)) {Move(RIGHT); return;}
    }

    void Move(Direction dir) {
        switch (dir) {
            case UP:
                character.position += new Vector3();
            break;
        }
    }
}
