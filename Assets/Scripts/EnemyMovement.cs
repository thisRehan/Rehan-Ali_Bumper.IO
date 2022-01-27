using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody characterRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        characterRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    { 
       if(player!=null)
       {
            float speed = 10;
            Vector3 playerPosition = (player.transform.position - transform.position).normalized;
            characterRb.AddForce(playerPosition * speed);
       }
    }
}
