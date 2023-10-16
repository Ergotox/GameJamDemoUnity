using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CERRAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FuncionCerrar()
    {
        Application.Quit();
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }
}
