using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference lightAction;
    
    private Light _light;
    private Color oldColor;

    private void Start()
    {
        _light = GetComponent<Light>();
        oldColor = _light.color;
        lightAction.action.Enable();
        lightAction.action.performed += (ctx) =>
        {
            if (oldColor == _light.color)
                _light.color = new Color32(178, 34, 34, 255);
            else
                _light.color = oldColor;
        };
    }
}
