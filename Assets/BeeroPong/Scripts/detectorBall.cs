using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class detectorBall : MonoBehaviour
{
    public Text escor;

    public bool coroutuineStarted = false;
    // Start is called before the first frame update
    void Start()
    {
      escor.text = adminPuntos.PuntajeRef.ToString();
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "ballA") //lee el tag del objeto que va a detectar
        {
            
         if(!coroutuineStarted)
         StartCoroutine(UsingYieldB(5));
    

            
        }

        if(collider.gameObject.tag == "ballB") //lee el tag del objeto que va a detectar
        {
            
         if(!coroutuineStarted){
         StartCoroutine(UsingYieldA(5));   

        }    
        }
        
    }

   IEnumerator UsingYieldA(int seconds)
   {
      coroutuineStarted = true;
      yield return new WaitForSeconds(5);
      coroutuineStarted = false;
      //SceneManager.LoadScene(1);
   } 

      IEnumerator UsingYieldB(int seconds)
   {
      coroutuineStarted = true;
      yield return new WaitForSeconds(5);
      coroutuineStarted = false;
      //SceneManager.LoadScene(0);
   } 

         IEnumerator UsingYieldC(int seconds)
   {
      coroutuineStarted = true;
      yield return new WaitForSeconds(5);
      coroutuineStarted = false;
      //SceneManager.LoadScene(2);
   } 
}
