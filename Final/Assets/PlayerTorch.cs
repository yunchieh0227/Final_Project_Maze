using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTorch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Light torch;

    // Update is called once per frame
    void Update()
    {
        torch.intensity -= 0.0001f;
    }
}
