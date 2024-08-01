using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class SplineInQuotes : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] Vector3 initialVel;
    [SerializeField] Vector3 changePerFrame;
    [SerializeField] Vector3 changePerFrame_2;
    [SerializeField] float moveSpeed;
    private float counter = 0.3f;
    private int inCounter = 0;
    [SerializeField] private int turnTime = 10;
    public GameObject ringClone;
    public Vector3 rotateby;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVel;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * moveSpeed;
        counter -= Time.deltaTime;
        var newRotation = transform.localRotation;
        newRotation *= Quaternion.Euler(rotateby.x, rotateby.y, rotateby.z);
        if (counter < 0f) {/*Instantiate(ringClone, transform.position, newRotation);*/ counter = 0.3f; inCounter++;}
        
        if (inCounter >= turnTime) {
            transform.RotateAround(transform.position, transform.right, Time.deltaTime * rotateSpeed);
        } else {transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotateSpeed);}
        //counter -= Time.deltaTime;
        //var newRotation = transform.localRotation;
        //newRotation *= Quaternion.Euler(rotateby.x, rotateby.y, rotateby.z); // this adds a 90 degrees Y rotation
        //
        //rb.velocity += ((inCounter >= turnTime) ? changePerFrame_2 : changePerFrame) * Time.deltaTime;
        //transform.LookAt(transform.position + rb.velocity);
    }
}
