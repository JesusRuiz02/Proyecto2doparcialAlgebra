using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
   // private float horizontalinput=1;
    private float verticalinput=1;
    private Vector3 mousePosition;
    public float speed=4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate (speed * Time.deltaTime * Vector3.forward * verticalinput);

        }
        /*if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate (speed * Time.deltaTime * Vector3.right * -horizontalinput);

        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate (speed * Time.deltaTime * Vector3.forward * -verticalinput);

        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed * Time.deltaTime * Vector3.right * horizontalinput);

        }*/
        
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position); 
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
        transform.rotation =  Quaternion.Euler (new Vector3(0,-angle,0));
    }
 
        float AngleBetweenTwoPoints(Vector3 a, Vector3 b) 
        {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }
        
}


