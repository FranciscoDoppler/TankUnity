using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render : MonoBehaviour
{
    public bool activado = true;
    public GameObject gameObject;
    

    void Update()
    {
        if (activado)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("Activando render");
        }
        else 
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("Desactivando render");
        }
        
    }
}
