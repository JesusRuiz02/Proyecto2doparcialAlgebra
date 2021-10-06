using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala1 : MonoBehaviour
{
    public Color lineColor = Color.white;
    public GameObject cubeenemigo;
    public float ppunto, Temp1;
    

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

        if (distancia<=2)
        {
            if (ppunto<-.8f)
            {
                Temp1 += Time.deltaTime;//Contador de los segundos
            }   
        }

        if (Temp1 > 0)
        {
            
            GetComponent<Renderer>().material.color=Color.yellow;
        }
        
        if (Temp1>=4)//Condicion para que la pelota cambie de color
        {
            
            GetComponent<Renderer>().material.color = Color.HSVToRGB(30, 100, 100);
        }
        
        if (Temp1>=6)
        {
           
            GetComponent<Renderer>().material.color=Color.red;
            
        }
        
        
        
    }
}

