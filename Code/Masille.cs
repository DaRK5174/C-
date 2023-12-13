using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masille : MonoBehaviour
{
    float speed = 4.5f;
    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.position +=transform.forward *speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
        Destroy(gameObject);
    }
}
