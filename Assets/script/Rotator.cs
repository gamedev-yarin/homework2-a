using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  This component rotates the object
 */

public class Rotator : MonoBehaviour
{
    [SerializeField]
    float Speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Speed);
    }
}
