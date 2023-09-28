using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float height;
    public bool drunk;
    void Update()
    {
        transform.position = target.position - transform.forward * height;
        if (drunk == true)
        {
            if (height != 20)
            {
                height += 1 * Time.deltaTime;
            }
            if (height > 20)
            {
                height = 1;
            }
        }
    }

    
     
}
