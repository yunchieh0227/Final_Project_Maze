using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraRotation : MonoBehaviour
{
    public Transform cameraDirection;
    public Transform playerDirection;
    public Transform MinimapCamera;
    public Transform Torch;

    private float dirX;
    private float dirY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")) {
            SceneManager.LoadScene("StartScene");
        }
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * 200;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * 200;

        dirY += mouseX;
        dirX -= mouseY; 

        dirX = Mathf.Clamp(dirX, -90f, 30f);

        transform.rotation = Quaternion.Euler(dirX, dirY, 0);
        MinimapCamera.rotation = Quaternion.Euler(90, dirY, 0);
        Torch.rotation = Quaternion.Euler(0, dirY, 0);
        playerDirection.rotation = Quaternion.Euler(0, dirY, 0);
    }
}
