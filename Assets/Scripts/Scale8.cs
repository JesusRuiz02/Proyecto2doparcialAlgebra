using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale8 : MonoBehaviour
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

        if (distancia<=2)//Condicion para que este en rango
        {
            if (ppunto<-.8f)//Si esta en ppunto menor a -.8
            {
                Temp1 += Time.deltaTime;//Empiece el contador
            }   
        }
        
        if (Temp1>=0)//Condicion para que la pelota 1 cambie de color
        {
            
            GetComponent<Renderer>().material.color = Color.HSVToRGB(30, 100, 100);
        }
        else if (Temp1>=2)
        {
           
            GetComponent<Renderer>().material.color=Color.red;
            
        }
       
        
        
       /* if (CompareTag("Escala.8"))//Se compara la tag para que vaya y mueva nada mas su variable
        {
            if (distancia<3)//Se compara la distancia
            {
                if (ppunto<-.8f)
                {
                    Temp1 += Time.deltaTime;
                }
                else
                {
                    Temp1 = Temp1;
                }
            }
           
        }
        if (CompareTag("Escala8(2)"))
        {
            if (distancia<2)
            {
                if (ppunto<-.8f)
                {
                    Temp2 += Time.deltaTime;
                }
                else
                {
                    Temp2 = Temp2;
                }
            }
           
        }
        if (CompareTag("Escala8(3)"))
        {
            if (distancia<2)
            {
                if (ppunto<-.8f)
                {
                    Temp3 += Time.deltaTime;
                }
                else
                {
                    Temp3 = Temp3;
                }
            }
           
        }

        if (Temp1>=0)//Condicion para que la pelota 1 cambie de color
        {
            Sphere1.GetComponent<Renderer>().material.color = Color.HSVToRGB(239, 127, 26);
        }
        else if (Temp1>=2)
        {
            Sphere1.GetComponent<Renderer>().material.color=Color.red;
            
        }
        else
        {
            Sphere1.GetComponent<Renderer>().material.color = Color.gray;
        }
        
        
        //Condicion de la pelota2 para que cambie de color
        if (Temp2>=0)
        {
            Sphere2.GetComponent<Renderer>().material.color = Color.HSVToRGB(239, 127, 26);
        }
        else if (Temp2>=2)
        {
            Sphere2.GetComponent<Renderer>().material.color=Color.red;
            
        }
        else
        {
            Sphere2.GetComponent<Renderer>().material.color = Color.gray;
        }
        //Condicion de la pelota3 para que cambie de color
        if (Temp3>=0)
        {
            Sphere3.GetComponent<Renderer>().material.color = Color.HSVToRGB(239, 127, 26);
        }
        else if (Temp3>=2)
        {
            Sphere3.GetComponent<Renderer>().material.color=Color.red;
            
        }
        else
        {
            Sphere3.GetComponent<Renderer>().material.color = Color.gray;
        }
        */
        
    }
}
