using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
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
        if (other.transform.CompareTag("Chevre"))
        {
            Destroy(gameObject);
        }
       
        if (other.transform.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
       
    }
    
    
    
    
    
    
}
