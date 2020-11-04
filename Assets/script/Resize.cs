using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  this component increase and decrease the size of the object.
 */

public class Resize : MonoBehaviour
{
    [SerializeField]
    float maxSize = 2f;
    [SerializeField]
    float minSize = 0.5f;
    [Tooltip("The speed of increase / decrease")]
    [SerializeField]
    float Speed = 1f;
    [Tooltip("compare the x-axis to max size and min size")]
    [SerializeField]
    bool compareX = true;
    [Tooltip("compare the y-axis to max size and min size")]
    [SerializeField]
    bool compareY = true;


    private bool increase = true;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 size = transform.localScale;
        float tSpeed = Speed / 100;
        if (increase) //increase
        {
            transform.localScale += new Vector3(tSpeed, tSpeed, 0f);
        }
        else //decrease
        {
            transform.localScale -= new Vector3(tSpeed, tSpeed, 0f);
        }
        if (compareX && !compareY) // Checks the x-axis and not the y-axis
        {
            if (size.x >= maxSize) increase = false;
            if (size.x <= minSize) increase = true;
        }
        if (!compareX && compareY) //Checks the y-axis and not the x-axis
        {
            if (size.y >= maxSize) increase = false;
            if (size.y <= minSize) increase = true;
        }
        if (compareX && compareY) //Checks the x-axis and the y-axis
        {
            if (size.x >= maxSize || size.y >= maxSize) increase = false;
            if (size.x <= minSize || size.y <= minSize) increase = true;
        }
    }
}
