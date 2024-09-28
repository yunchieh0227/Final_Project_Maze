using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapSound : MonoBehaviour
{
    public AudioSource trap;
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

            trap.Play();



        }
    }
}
