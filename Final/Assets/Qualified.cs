using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qualified : MonoBehaviour
{
    public GameObject Diamond;
    public GameObject Tree1;
    public GameObject Tree2;
    public GameObject Tree3;
    public GameObject Tree4;
   // public GameObject DisappearWall1;
    //public GameObject DisappearWall2;
    public GameObject BoomWall1;
    public GameObject BoomWall2;
    public GameObject BoomWall3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "PlayerPart") {
            
            Diamond.SetActive(false);
            Tree1.SetActive(false);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
           // DisappearWall1.SetActive(false);
           // DisappearWall2.SetActive(false);

            BoomWall1.SetActive(true);
            BoomWall2.SetActive(true);
            BoomWall3.SetActive(true);
        }
    }
}
