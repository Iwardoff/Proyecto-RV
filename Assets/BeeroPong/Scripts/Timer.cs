using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Text contador;
    public float tiempo = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = "Tiempo Restante:" + tiempo.ToString("f0");
        
        if(tiempo == 0){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);    
        }

    }


}
