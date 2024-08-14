using UnityEngine;

public static class PlayerProperties {
    public static bool canMove = false;
    public static bool canFlash = true;
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
    [SerializeField] private SO_StartConditions startConds;
    private Vector3 moveVec;
    private Vector3 currentMoveS;
    private Rigidbody rb;
    public bool ignoreStartConditions;
    void Awake() {
        PlayerProperties.canMove = false;
        rb = GetComponent<Rigidbody>();
        if (ignoreStartConditions) {return;}
        if (startConds.startLocation == SO_StartConditions.StartLocation.None) {
            transform.position = new Vector3(6.45f,0.5f,24.43f);
        }
        else if (startConds.startLocation == SO_StartConditions.StartLocation.Tower) {
            transform.position = new Vector3(79.7f,0.5f,-267.43f);
        }
    }


    void FixedUpdate() {
        if (!PlayerProperties.canMove) {return;}
        Vector3 currentMove = new(0,0,0);

        if (Input.GetKey(KeyCode.W)) {currentMove += upVec;}
        if (Input.GetKey(KeyCode.A)) {currentMove += leftVec;}
        if (Input.GetKey(KeyCode.S)) {currentMove += downVec;}
        if (Input.GetKey(KeyCode.D)) {currentMove += rightVec;}

        var dVel = rb.velocity.y;

        currentMove = currentMove.normalized;
        currentMove *= playerAccel;
        currentMoveS = currentMove;
        moveVec += currentMove;

        if (moveVec.magnitude > playerSpeed) {moveVec = moveVec.normalized * playerSpeed;}
        moveVec *= 1 - frictionDecay;
        if (!Physics.Raycast(transform.position + (moveVec.normalized * 0.6f), Vector3.down, 1f)) {moveVec = Vector3.zero;}
        rb.velocity = moveVec;
        rb.velocity = new Vector3(rb.velocity.x,dVel,rb.velocity.z);
    }
}
