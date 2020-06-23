using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUI_Manager : MonoBehaviour
{
    public GameObject JButton;


    public void CambioTurno(string nombredeescena)
    {
        SceneManager.LoadScene(1);
    }
    public void CambioTurno2(string nombredeescena)
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer_Script.CurrentTime <= 0)
        {
            JButton.SetActive(true);
          
        }
    }
}
