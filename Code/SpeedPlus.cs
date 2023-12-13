using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPlus : MonoBehaviour
{
    public float SpeedFactor = 2.5f;
    private void OnTriggerEnter(Collider collider)
    {
        collider.GetComponent<FirstPersonMovement>().runSpeed = collider.GetComponent<FirstPersonMovement>().runSpeed *= SpeedFactor;
        collider.GetComponent<FirstPersonMovement>().speed = collider.GetComponent<FirstPersonMovement>().speed *= SpeedFactor;
    }
    private void OnTriggerExit(Collider collider)
    {
        collider.GetComponent<FirstPersonMovement>().runSpeed = collider.GetComponent<FirstPersonMovement>().runSpeed /= SpeedFactor;
        collider.GetComponent<FirstPersonMovement>().speed = collider.GetComponent<FirstPersonMovement>().speed /= SpeedFactor;

    }
}
