using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20f;
    private float _turnSpeed = 50f;    
    private float _horizontalInput;
    private float _forwardlInput;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardlInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardlInput);
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);
    }
}
