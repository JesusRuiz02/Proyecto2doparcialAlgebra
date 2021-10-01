using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Productopunto : MonoBehaviour
{

    public Color lineColor = Color.white;

    public GameObject cubeenemigo;
    public float ppunto;

    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(cubeenemigo.transform.position, transform.position);
        Debug.DrawRay(transform.position, transform.forward.normalized*15, lineColor);
        ppunto = Vector3.Dot(transform.forward.normalized,cubeenemigo.transform.forward.normalized);

       // if (ppunto < -.8f)
        //{
           // GetComponent<Renderer>().material.color=Color.red;
      //  }
        // if (distancia<3)
     //   {
            // GetComponent<Renderer>.material.color()=Color.red;
            // }
        }
    
  
}
