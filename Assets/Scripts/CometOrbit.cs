using System;
using UnityEngine;

public class CometOrbit : MonoBehaviour
{
    public float gravity = 0.2f;
    private Vector3 _velocity = Vector3.zero;
    void Update()
    {
        double distance = Math.Sqrt( Math.Pow(transform.position.x, 2) + Math.Pow (transform.position.y, 2) + Math.Pow(transform.position.z, 2) );
        distance = Math.Max(0.1f, distance);
        double ax = - gravity * transform.position.x / Math.Pow(distance, 3);
        double ay = - gravity * transform.position.y / Math.Pow(distance, 3);
        double az = - gravity * transform.position.z / Math.Pow(distance, 3);
        _velocity.x = (float)(_velocity.x + ax * Time.deltaTime);
        _velocity.y = (float)(_velocity.y + ay * Time.deltaTime);
        _velocity.z = (float)(_velocity.z + az * Time.deltaTime);
        transform.transform.Translate(_velocity);
    }
}
