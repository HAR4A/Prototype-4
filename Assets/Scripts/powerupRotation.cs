using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupRotation : MonoBehaviour
{
    private float speed = 150f;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
