using System;
using UnityEngine;
 
public class CometOrbit : MonoBehaviour
{
    public Vector3 velocity;

    public double gravity = 0.2;
    public GameObject attractor;

    void Start()
    {
        if (attractor == null)
        {
            attractor = GameObject.Find("Planet");
        }
    }
    
    void Update()
    {
        Vector3 position = transform.position - attractor.transform.position;
 
        double distance = Math.Sqrt(
            Math.Pow(position.x, 2) +
            Math.Pow(position.y, 2) +
            Math.Pow(position.z, 2)
        );

        distance = Math.Max(1f, distance);
 
        double ax = -gravity * position.x / Math.Pow(distance, 3);
        double ay = -gravity * position.y / Math.Pow(distance, 3);
        double az = -gravity * position.z / Math.Pow(distance, 3);
 
        velocity.x += (float)(ax * Time.deltaTime);
        velocity.y += (float)(ay * Time.deltaTime);
        velocity.z += (float)(az * Time.deltaTime);
 
        transform.position += velocity * Time.deltaTime;
    }
}
