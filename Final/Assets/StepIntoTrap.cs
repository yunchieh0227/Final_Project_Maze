using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepIntoTrap : MonoBehaviour
{
    public GameObject Syurikenn;
    GameObject Prefab;
    public GameObject Launcher;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "player") {
            for(int i = 0; i < 15; i++) {
                Prefab = Instantiate(Syurikenn, Launcher.transform.position + new Vector3(0.5f, 0, i), Quaternion.identity);
                Prefab.GetComponent<Rigidbody>().AddForce(new Vector3(1.0f, 0, 0) * 1000);
                Destroy(Prefab, 1);
            }
        }
    }
}
