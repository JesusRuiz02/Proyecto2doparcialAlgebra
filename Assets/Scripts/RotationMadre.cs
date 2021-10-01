using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMadre : MonoBehaviour
{
    Productopunto productopunto;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(productopunto.distancia<4)
        {
            transform.Rotate(1, 0, 0);
        }
    }
}
