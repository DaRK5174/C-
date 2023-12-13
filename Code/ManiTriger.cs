using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManiTriger : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0,2,0);
    }
    private void OnTriggerEnter(Collider player)
    {
        player.GetComponent<Player>().coins++;
        Destroy(gameObject);
        print("колличество монеток:" + player.GetComponent<Player>().coins + "/10");
    }
}
