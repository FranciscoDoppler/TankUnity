using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cOLISION : MonoBehaviour
{
    //private void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.name == "Cube") ;
    //    {
    //        Destroy(col.gameObject);
    //    }
    //}
    
        //private void OnCollisionStay(Collision col)
        //{
        //    if (col.gameObject.name == "Cube");
        //    {
        //        //Destroy(col.gameObject);
        //      Debug.Log("he colisionado con: " + col.gameObject.name);
        //    }
        //}

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Cube");
        {
            //Destroy(col.gameObject);
            Debug.Log("he salido de: " + col.gameObject.name);
        }
    }




}
