using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins = 0;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }

    public void takeDamage(int Damage)
    {
        health -= Damage;
        if (health > 0)
        {
        print("Здоровье игрока:" + health);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }

   
}

