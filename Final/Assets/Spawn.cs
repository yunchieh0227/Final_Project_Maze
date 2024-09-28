using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy;
    float cd = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cd < 3)
            cd += 0.005f;
        if(cd > 2.5)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            Destroy(transform);
        }
            
        


    }
}
