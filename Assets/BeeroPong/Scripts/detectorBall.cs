using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorBall : MonoBehaviour
{
    public Launcher lnch;
    public bool coroutuineStarted = false;
    public cameraSwitch cmrSwtch; //para que funcione, necesita un objeto en la escena que tenga el script "SwitchCamera"
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
        if(collider.gameObject.tag == "ball"||collider.gameObject.tag == "ballA"||collider.gameObject.tag == "ballB") //lee el tag del objeto que va a detectar
        {
         if(!coroutuineStarted)
         StartCoroutine(UsingYield(1));
         lnch.puedeLanzar = false;    
          //cambia de cámara
            
        }
        
    }

   IEnumerator UsingYield(int seconds)
   {
      coroutuineStarted = true;
 
      yield return new WaitForSeconds(5);
      coroutuineStarted = false;
      cmrSwtch.cameraChangeCounter();
      lnch.puedeLanzar = true; 
   } 
}
