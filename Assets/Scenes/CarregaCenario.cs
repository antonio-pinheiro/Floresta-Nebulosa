using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregaCenario : MonoBehaviour
{
    public void Trocar()
    {
        SceneManager.LoadScene("interior_casa");
    }
}
