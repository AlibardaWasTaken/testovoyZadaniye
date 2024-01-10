using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private Transform _targetcube;

    [SerializeField]
    private float _speed;


    private Vector3 _directionToTarget;

    [SerializeField]
    private Transform _particleSystemTransform;

    private Quaternion _targetRotation ;
    private Vector3 _targetRotationVector;

    [SerializeField]
    private bool _IsArrowControled;


    private string _horizontalControl;
    private string _verticalControl;


    void Start()
    {
        _targetRotationVector = new Vector3(0, 1, 1);


        if (_IsArrowControled)
        {
            _horizontalControl = "Horizontal_Arrow";
            _verticalControl = "Vertical_Arrow";
        }
        else
        {
            _horizontalControl = "Horizontal_WASD";
            _verticalControl = "Vertical_WASD";
        }
    }









    void Update()
    {
        ControlParticles();

        MovementControl();

    
    }



    private float _horizontalInput;
    private float _verticalInput;
 
    private void MovementControl()
    {
        _horizontalInput = Input.GetAxis(_horizontalControl);
        _verticalInput = Input.GetAxis(_verticalControl);

        Vector3 movement = new Vector3(_horizontalInput, 0f, _verticalInput).normalized;

        transform.Translate(movement * _speed * Time.deltaTime);

        
    }




    private void ControlParticles()
    {
        _directionToTarget = _targetcube.position - _particleSystemTransform.position;
        _targetRotation = Quaternion.LookRotation(_directionToTarget, _targetRotationVector);
        _particleSystemTransform.rotation = _targetRotation;
    }
}
