using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dablDgump : MonoBehaviour
{
    float JumpFactor = 2.8f;
    private void OnTriggerEnter(Collider collider)
    {
        collider.GetComponent<Jump>().jumpStrength *= JumpFactor;
    }

    private void OnTriggerExit(Collider collider)
    {
        collider.GetComponent<Jump>().jumpStrength /= JumpFactor;
    }
}
