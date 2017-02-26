using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour
{
    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelRL;
    public WheelCollider WheelRR;
    public float maxTorque = 1500f;
    void Start()
    {
        Rigidbody rb = (Rigidbody)GetComponent(typeof(Rigidbody));
        Vector3 temp = rb.centerOfMass;
        temp.y = -0.9f; //the f indicates that this is a floating point variable. 
        rb.centerOfMass = temp;
    }
    void FixedUpdate()
    {
        WheelRR.motorTorque = maxTorque * Input.GetAxis("Vertical");
        WheelRL.motorTorque = maxTorque * Input.GetAxis("Vertical");
        WheelFL.steerAngle = 10 * Input.GetAxis("Horizontal");
        WheelFR.steerAngle = 10 * Input.GetAxis("Horizontal");
    }
}

