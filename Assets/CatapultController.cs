using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpringJoint))]
public class CatapultController : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint; 
    [SerializeField] private Transform _spoon; 
    [SerializeField] private GameObject _projectilePrefab; 
    [SerializeField] private Vector3 _projectileOffset; 
    private float _maxSpring = 500f; 
    private float _minSpring = 0f; 

    private GameObject _currentProjectile;

    private void Start()
    {
        _springJoint = GetComponent<SpringJoint>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            RaiseSpoon();
        }

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            ReturnSpoon();
        }
    }

    private void RaiseSpoon()
    {
        _springJoint.spring = _minSpring;

        _currentProjectile = Instantiate(_projectilePrefab, _spoon.position + _projectileOffset, _spoon.rotation);
    }

    private void ReturnSpoon()
    {
        _springJoint.spring = _maxSpring; 
    }
}
