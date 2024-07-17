using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class SwingController : MonoBehaviour
{
    private float _force = 100f; 
    private float _targetVelocity = 100f;

    private HingeJoint _hingeJoint;
    private JointMotor _motor;

    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _motor = _hingeJoint.motor;
            _motor.force = _force;
            _motor.targetVelocity = _targetVelocity;
            _hingeJoint.motor = _motor;
            _hingeJoint.useMotor = true;
        }
        else
        {
            _hingeJoint.useMotor = false;
        }
    }
}
