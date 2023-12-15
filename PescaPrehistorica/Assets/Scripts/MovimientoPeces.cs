using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPeces : MonoBehaviour
{
    public float swimSpeed = 2f;       // Adjust the swim speed as needed
    public float rotationSpeed = 5f;   // Adjust the rotation speed as needed
    public float circleRadius = 5f;    // Adjust the radius of the circle

    private float angle = 0f;

    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    void Update()
    {
        // Calculate the new position in a circle
        float x = Mathf.Cos(angle) * circleRadius;
        float z = Mathf.Sin(angle) * circleRadius;

        // Set the new position
        transform.position = new Vector3(x, transform.position.y, z);

        // Increment the angle for the next frame
        angle += rotationSpeed * Time.deltaTime;

        // Rotate the fish to face the direction of motion
        transform.rotation = Quaternion.LookRotation(new Vector3(x, 0f, z));

        // Optionally, you can add the forward movement
        // transform.Translate(Vector3.forward * swimSpeed * Time.deltaTime);
    }
}