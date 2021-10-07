using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Productopunto : MonoBehaviour
{
    
    public Color lineColor = Color.white;
    public GameObject cubeenemigo;
    public float ppunto;
    public float contadormaximo;
    public float randomrange;
    public float timer;
    public float distancia;

    private AudioSource Aaaaa;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        Aaaaa = gameObject.GetComponent<AudioSource>();
        Aaaaa.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(cubeenemigo.transform.position, transform.position);
        Debug.DrawRay(transform.position, transform.forward.normalized*10, lineColor);
        ppunto = Vector3.Dot(transform.forward.normalized,cubeenemigo.transform.forward.normalized);
        contadormaximo = Random.Range(1, 3);

       
         if (distancia<3)//Si la distancia es menor a 3 del jugador
         {
             timer += Time.deltaTime;//Que empiece el contador
            
             if (timer>=contadormaximo)// Si el contador es mayor al limite
             {
                 
                 randomrange = Random.Range(-10, 45);
                 transform.Rotate(0,randomrange,0);//Que rote entre -10 y 45
                 timer = 0;//Reinicia contador
                 contadormaximo = Random.Range(1, 3);//Reinicia limite
             }

             if (ppunto< -.8f)
             {
                // cubeenemigo.GetComponent<Renderer>().material.color = Color.red;
                 Time.timeScale = 0;
                     Aaaaa.volume = 1;

             }
             else
             {
                 Aaaaa.volume = 0;
             }

         }
         
        
        
         
         
    }

   

   
}
