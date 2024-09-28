using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class heal : MonoBehaviour
{

    public GameObject Bar1;
    public GameObject Bar2;
    public GameObject Bar3;
    public GameObject Bar4;
    public GameObject Bar5;
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
        if (other.gameObject.name == "PlayerPart" || other.gameObject.name == "player")
        {
            
            if (Bar2.activeSelf == false)
                Bar2.SetActive(true);
            else if (Bar3.activeSelf == false)
                Bar3.SetActive(true);
            else if (Bar4.activeSelf == false)
                Bar4.SetActive(true);
            else 
                Bar5.SetActive(true);
            


        }
    }
}
