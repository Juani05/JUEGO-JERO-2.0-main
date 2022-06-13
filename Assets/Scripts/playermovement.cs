using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playermovement : MonoBehaviour
{
    public float turningSpeed;
    public float movementSpeed;
    public GameObject myobject;
  
    // Start is called before the first frame update
    void Start()
    {
        //myobject.transform.position = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
 
       transform.Translate(0, 0, movementSpeed);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(movementSpeed, 0, 0) * turningSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(movementSpeed, 0, 0)* turningSpeed * Time.deltaTime;

        }
    }
}