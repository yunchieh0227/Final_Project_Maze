using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moreLight : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.name == "player")
        {

            light.intensity += 3;
            if (light.intensity > 5)
                light.intensity = 5;



        }
    }
}
