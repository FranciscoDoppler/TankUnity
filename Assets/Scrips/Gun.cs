using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //Agregan punto de inicio de donde la bala saldra.
    public GameObject BalaInicio;
    //Agregan Bala Prefab
    public GameObject BalaPrefab;
    //Agregar Bala Velocidad
    public float BalaVelocidad;

    private float TimeBala = 0;
    public float showRate = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time > TimeBala)
            {
                //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
                GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;

                //Obtener Rigidbody para agregar Fuerza. 
                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                //Agregar la fuerza a la Bala
                rb.AddForce(transform.forward * BalaVelocidad);

                TimeBala = Time.time + showRate;

                //Debemos Destruir la bala
                Destroy(BalaTemporal, 5.0f);

                TimeBala += Time.deltaTime;
            }
        }
    }
}