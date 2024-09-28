using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Torch : MonoBehaviour
{
    public Slider slider;
    public Light torch;
    // Start is called before the first frame update
    void Start()
    {
        torch.intensity = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            slider.value -= 1.0f;
            torch.intensity = slider.value;
        }
        if (Input.GetKeyDown("g"))
        {
            slider.value += 1.0f;
            torch.intensity = slider.value;
        }
    }

    private void FixedUpdate() {
        slider.value = torch.intensity;
    }
}
