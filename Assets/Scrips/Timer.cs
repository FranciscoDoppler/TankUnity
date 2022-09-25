using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeleft = 10.0f;
    public bool termino = false;

    //IEnumerator tiempo() 
    //{
    //    for (int i = 0; i < 60; i++) 
    //    {
    //        Debug.Log("el tiempo es " + i);
    //        yield return new WaitForSeconds(1);
    //    }
        
    //}

    private void Start()
    {
        //StartCoroutine(tiempo());
    }

    private void Update()
    {
        if (!termino)
        {
            timeleft -= Time.deltaTime;
            if (timeleft < 0)
            {
                GameOver();
            }
        }
        else { Debug.Log("el proceso terminoos"); }
    }

    void GameOver()
    {
        Debug.Log("el juego termino...");
        termino = true;
    }
}
