using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTriger : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.transform.position = teleportPoint.position;
    }
}
