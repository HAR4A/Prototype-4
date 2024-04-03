using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float rotationSpeed = 50;


    void Update()
    {   // !!!!! in project settings in Input manager, we can use Invert, for a normal (the usual) control
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
