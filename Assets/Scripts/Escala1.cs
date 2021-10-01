using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala1 : MonoBehaviour
{
    Productopunto productopunto;
    GameObject escala1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (productopunto.distancia<3)
        {
        // GetComponent<Renderer>.material.color()=Color.red;
        }
    }
}

