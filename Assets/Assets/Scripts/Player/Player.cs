using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class Player : MonoBehaviour
{
    private InputMaster controls;

    public float speed;

    private RobotTrigger touchedTrigger;

    private void OnEnable()
    {
        controls = new InputMaster();
        
        controls.Enable();

        controls.Player.Use.performed += OnUseStartPerformed;
        controls.Player.UseHold.performed += OnUsePerformed;

    }

    private void OnUseStartPerformed(InputAction.CallbackContext obj)
    {
        if (touchedTrigger != null && !touchedTrigger.isHoldTrigger)
        {
            touchedTrigger.Use();
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = Gamepad.current.leftStick.ReadValue() * Time.deltaTime * speed;
        transform.position += new Vector3(direction.x, 0, direction.y);
    }

    private void OnDisable()
    {
        controls.Player.Use.performed -= OnUsePerformed;
    }

    private void OnTriggerEnter(Collider other)
    {
        RobotTrigger trigger = other.transform.GetComponent<RobotTrigger>();

        if (trigger)
        {
            touchedTrigger = trigger;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        RobotTrigger trigger = other.transform.GetComponent<RobotTrigger>();

        if (trigger)
        {
            touchedTrigger = null;
        }
    }

    private void OnUsePerformed(InputAction.CallbackContext obj)
    {
        if (touchedTrigger != null && touchedTrigger.isHoldTrigger)
        {
            touchedTrigger.Use();
        }
    }
}
