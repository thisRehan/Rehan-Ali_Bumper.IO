using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Texture[] textures;
    private GameObject LastHitBy = null;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        OutOfBound();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Character"))
            LastHitBy = collision.gameObject;       
    }
    void OutOfBound()
    {
        int LowerBoundary = -2;
        if(transform.position.y < LowerBoundary)
        {
            Destroy(gameObject);
            if (LastHitBy != null)
                increase();  
        }
    }
    void increase()
    {
        AddScale();
        AddMass();
        ChangeTexture();
    }
    void AddScale()
    {
        Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);
        LastHitBy.transform.localScale += scale;
    }
    void AddMass()
    {
        float mass = 0.5f;
        LastHitBy.GetComponent<Rigidbody>().mass += mass;
    }
    void ChangeTexture()
    {
        int index = Random.Range(0, textures.Length);
        LastHitBy.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", textures[index]);
    }
}
