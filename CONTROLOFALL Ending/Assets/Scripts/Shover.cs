using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shover : MonoBehaviour
{
    [SerializeField] private float amount;
    [SerializeField] private Vector3 shoveDirection;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(shoveDirection * amount, ForceMode.VelocityChange);
    }
}
