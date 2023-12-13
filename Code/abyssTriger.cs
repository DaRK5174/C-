using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abyssTriger : MonoBehaviour
{
    public Transform teleportPoint;
    private void OnTriggerEnter(Collider collider)
    {
        collider.transform.position = teleportPoint.position;
    }
}
