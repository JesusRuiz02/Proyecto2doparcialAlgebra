using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale6 : MonoBehaviour
{
    public Color lineColor = Color.white;
    public GameObject cubeenemigo;
    public float ppunto, Temp1;
  
    //  public GameObject Sphere2;
    // public GameObject Sphere3;
    

    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(cubeenemigo.transform.position, transform.position);
        Debug.DrawRay(transform.position, transform.forward.normalized * 10, lineColor);
        ppunto = Vector3.Dot(transform.forward.normalized, cubeenemigo.transform.forward.normalized);

        if (distancia <= 2)
        {
            if (ppunto < -.8f)
            {
                Temp1 += Time.deltaTime;
            }
        }



        if (Temp1 >= 2)
        {
            
            GetComponent<Renderer>().material.color = Color.red;

        }
    }
}
