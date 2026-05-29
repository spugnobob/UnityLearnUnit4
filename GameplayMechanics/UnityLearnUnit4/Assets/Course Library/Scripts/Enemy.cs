using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Rigidbody enemyRb;
    private GameObject Player;



    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }




    void Update()
    {
        Vector3 lookDirection = (Player.transform.position - transform.position);
        enemyRb.AddForce(lookDirection * speed);
    }
}
