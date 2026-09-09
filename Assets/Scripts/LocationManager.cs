using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class LocationManager : MonoBehaviour
{
    public UnityEvent teleported;
    public GameObject[] locations;
    public InputActionReference inputAction;
    private int _currentLocation = 0;

    private void Start()
    {
        inputAction.action.Enable();
        inputAction.action.performed += (ctx) =>
        {
            GoToNextLocation();
            teleported.Invoke();
        };
    }

    private void GoToNextLocation()
    {
        _currentLocation++;
        if (_currentLocation >= locations.Length)
        {
            _currentLocation = 0;
        }
        transform.position = locations[_currentLocation].transform.position;
    }
}
