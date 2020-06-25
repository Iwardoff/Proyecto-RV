using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adminTiempos : MonoBehaviour
{
    public Timer tiempo1;
    public Timer tiempo2;
    public adminTiempos admnTmps;
    void Awake(){
        admnTmps = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo1== 0)
        {
            SceneManager.LoadScene (1);
        }

        if (tiempo2.tiempo == 0)
        {
            SceneManager.LoadScene (2);
        }


    }
}
