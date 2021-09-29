using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontalinput;
    private float verticalinput;
    private Vector3 mousePosition;

    public float speed=4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        
        this.transform.Translate(speed*Time.deltaTime*Vector3.right*horizontalinput);
        this.transform.Translate(speed*Time.deltaTime*Vector3.forward*verticalinput);
        /*if (Input.GetMouseButton(1))
        {

            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.Rotate(0,,mousePosition.z);
        }
        //rotacion*/
        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
         
        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
         
        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
 
        //Ta Daaa
        transform.rotation =  Quaternion.Euler (new Vector3(0f,-angle,0));
    }
 
        float AngleBetweenTwoPoints(Vector3 a, Vector3 b) 
        {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }
        
}


