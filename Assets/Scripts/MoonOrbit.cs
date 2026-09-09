using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, speed * Time.deltaTime, 0);
    }
}
