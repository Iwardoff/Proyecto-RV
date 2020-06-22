using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanish : MonoBehaviour
{
    
    public GameObject Bola;
    Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Vanisher")
        {
            Destroy(Bola.gameObject); //Bola
        }
        
    }
}
