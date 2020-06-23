using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public GameObject Caña;
    public GameObject JButton;


    public void CambioTurno(string nombredeescena)
    {
        SceneManager.LoadScene(5);
    }
    public void CambioTurno2(string nombredeescena)
    {
        SceneManager.LoadScene(6);
    }
    public void MenuP(string nombredeescena)
    {
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer_Script.CurrentTime <= 0)
        {
            Caña.SetActive(false);
            JButton.SetActive(true);
        }
    }
}
