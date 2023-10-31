using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePrefab : MonoBehaviour
{
    public float rotationSpeed = 10f; // Adjust the speed as needed

    void Update()
    {
        // Rotate the object around its Y-axis (upwards) by the specified speed
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
