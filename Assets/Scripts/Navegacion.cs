using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void InicioAMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void MainAInicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void MainAInfo()
    {
        SceneManager.LoadScene("Informacion");
    }

    public void InfoAMain()
    {
        SceneManager.LoadScene("Main");
    }
}
