using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public InputActionReference inputAction;
    public GameObject bullet;
    public float initForce = 10f;

    void Start()
    {
        inputAction.action.Enable();
        inputAction.action.performed += (ctx) =>
        {
            Vector3 spawnPosition = transform.position;
            Quaternion spawnRotation = Quaternion.identity;
            spawnRotation *= Quaternion.Euler(90f, 0f, 0f);

            var bulletInst = Instantiate(bullet, spawnPosition, spawnRotation);
            Rigidbody rb = bulletInst.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.linearVelocity = transform.forward * initForce;
            }
        };
    }
}
