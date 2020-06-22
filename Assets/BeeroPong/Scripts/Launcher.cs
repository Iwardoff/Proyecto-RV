using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject proyectilPrefab; //variable en la cual pondremos el proyectil
    public bool puedeLanzar = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

         if (Input.GetMouseButtonDown(0) && puedeLanzar == true){ //detecta el botón 1 del mouse y si puede lanzar
             Debug.Log("Pressed primary button.");
             GameObject bullet = Instantiate(proyectilPrefab, transform.position, Quaternion.identity) as GameObject; //instancia el objeto que definimos como proyectil
             bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 2500); //al instanciar ese objeto, le mete fuerza
         }
    }
}
