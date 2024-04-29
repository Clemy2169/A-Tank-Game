using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Chevre : MonoBehaviour
{
    public GameObject explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)

    {
        if (other.transform.CompareTag("Projectile"))
        {
            GameObject clone = Instantiate(explosion, transform.position, quaternion.identity);
            Destroy(gameObject);
        }


    }
}
