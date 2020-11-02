using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUnhide : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<SpriteRenderer>().enabled) GetComponent<SpriteRenderer>().enabled = false;
            else GetComponent<SpriteRenderer>().enabled = true;
        }
            


    }
}
