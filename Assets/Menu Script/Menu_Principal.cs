using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_Principal : MonoBehaviour
{
    public void Mole(string nombredeescena)
    {
        SceneManager.LoadScene(0);
    }
    public void Pesca(string nombredeescena)
    {
        SceneManager.LoadScene(4);
    }
}
