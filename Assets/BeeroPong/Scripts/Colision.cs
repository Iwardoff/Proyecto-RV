using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    
    public GameObject vaso;
    Collider collider;
    public adminPuntos Player;
    public adminPuntos Oponente;

    
    
    // Start is called before the first frame update
    void Start()
    {
       collider = GetComponent<Collider>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider collider)
    {

        if(collider.gameObject.tag == "ballA" && vaso.gameObject.tag == "vasoB"||collider.gameObject.tag == "ballB" && vaso.gameObject.tag == "vasoA"){
            Player.Puntaje = Player.Puntaje + 1;
            Oponente.vasosRestantes--;
            Debug.Log("funciona el metodo");
            Destroy(gameObject, .10f); //Cubo 
            Destroy(vaso, .10f); //Vaso
            Destroy(collider.gameObject, .10f); //Bola
            Debug.Log("colision con activador");
        }
        if(collider.gameObject.tag == "ballA" && vaso.gameObject.tag == "vasoA"||collider.gameObject.tag == "ballB" && vaso.gameObject.tag == "vasoB"){
            Oponente.Puntaje++;
            Player.vasosRestantes--;
            Debug.Log("funciona el metodo");
            Destroy(gameObject, .10f); //Cubo 
            Destroy(vaso, .10f); //Vaso
            Destroy(collider.gameObject, .10f); //Bola
            Debug.Log("colision con activador");
        }
        
    }
}

