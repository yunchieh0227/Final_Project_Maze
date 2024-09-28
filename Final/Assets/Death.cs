using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour

    
{
    public GameObject Enemy;
    public GameObject Bar1;
    public GameObject Bar2;
    public GameObject Bar3;
    public GameObject Bar4;
    public GameObject Bar5;
    float cd = 0;



    // Start is called before the first frame update
    void Start()
    {
        Bar5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cd < 3)
            cd += 0.01f;


    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "PlayerPart" || other.gameObject.name == "player") {
            if (cd < 2.5)
                return;
            if (Bar5.activeSelf == true)
                Bar5.SetActive(false);
            else if (Bar4.activeSelf == true)
                Bar4.SetActive(false);
            else if (Bar3.activeSelf == true)
                Bar3.SetActive(false);
            else if (Bar2.activeSelf == true)
                Bar2.SetActive(false);
            else 
                SceneManager.LoadScene("LoseScene");
            cd = 0;

            
        }
    }
}
