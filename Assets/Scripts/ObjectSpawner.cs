using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public UnityEvent onSpawn;

    public InputActionReference inputAction;
    public GameObject objectToSpawn;
    //public GameObject particles;

    void Start()
    {
        inputAction.action.Enable();
        inputAction.action.performed += (ctx) =>
        {
            Vector3 spawnPosition = transform.position;
            Quaternion spawnRotation = Quaternion.identity; 

            Instantiate(objectToSpawn, spawnPosition + (transform.forward * 1f), spawnRotation);
            //Instantiate(particles, spawnPosition + (transform.forward * 1f), spawnRotation);
            onSpawn.Invoke();
        };
    }
}
