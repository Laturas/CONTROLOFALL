using UnityEngine;

public static class PlayerProperties {
    public static bool canMove = false;
}

public class PlayerMovement : MonoBehaviour
{
    static Vector3 upVec = new(1,0,1);
    static Vector3 downVec = new(-1,0,-1);
    static Vector3 rightVec = new(1,0,-1);
    static Vector3 leftVec = new(-1,0,1);

    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerAccel;
    [SerializeField] private float frictionDecay;
    private Vector3 moveVec;
    private Vector3 currentMoveS;
    private Rigidbody rb;
    void Awake() {
        PlayerProperties.canMove = false;
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate() {
        if (!PlayerProperties.canMove) {return;}
        Vector3 currentMove = new(0,0,0);

        if (Input.GetKey(KeyCode.W)) {currentMove += upVec;}
        if (Input.GetKey(KeyCode.A)) {currentMove += leftVec;}
        if (Input.GetKey(KeyCode.S)) {currentMove += downVec;}
        if (Input.GetKey(KeyCode.D)) {currentMove += rightVec;}

        currentMove = currentMove.normalized;
        currentMove *= playerAccel;
        currentMoveS = currentMove;
        moveVec += currentMove;

        if (moveVec.magnitude > playerSpeed) {moveVec = moveVec.normalized * playerSpeed;}
        moveVec *= 1 - frictionDecay;
        rb.velocity = moveVec;
    }
}
