using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Productopuntoplayer : MonoBehaviour
{
    
    public Color lineColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward.normalized*10, lineColor);
        
    }
}
