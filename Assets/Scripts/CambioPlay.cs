using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioPlay : MonoBehaviour
{
    //[SerializeField] ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Este m�todo debe estar p�blico para que lo puedas asignar al bot�n desde el inspector.
    public void Cambiar_A_Game(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
