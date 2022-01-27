using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject character;
    private int enemy = 3;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        for(int i=0; i<enemy; i++)
        {
            float xRange = 9;
            float zRange = 9;
            Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), 0, Random.Range(-zRange, zRange));
            Instantiate(character, spawnPosition, character.transform.rotation);
        }
        
    }
}
