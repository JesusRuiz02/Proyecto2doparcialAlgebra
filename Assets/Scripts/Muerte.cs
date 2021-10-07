using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public Productopunto pp;
    public GameObject Cubo;
    public GameObject Zona_muerte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider MotherCollider)
    {
        Debug.Log("Entra");


        if (pp.ppunto > .8f)//Si el ppunto es menor a 8
        {
            Debug.Log("Game Over");//Pierdes
            Cubo.GetComponent<Renderer>().material.color = Color.red;
            //Time.timeScale = 0;
        };

    }
}
