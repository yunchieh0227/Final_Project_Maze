using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Player;
    public Transform Faced;
    Rigidbody rb;

    float verticalInput;
    float horizontalInput;

    bool enableToJump;

    Vector3 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        SpeedControll();
        if(Input.GetKeyDown("space") && InTheGround()) Jump();
    }

    private void FixedUpdate() {
        Move();
    }

    void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void Move()
    {
        moveDir = Faced.forward * verticalInput + Faced.right * horizontalInput;
        rb.AddForce(moveDir * 6.0f * 10.0f, ForceMode.Force);
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0, 1.0f, 0) * 25 * 12.0f);
    }

    bool InTheGround()
    {
        return transform.position.y <= 1.1f;
    }

    void SpeedControll()
    {
        Vector3 XZVelocity = new Vector3(rb.velocity.x, 0.0f, rb.velocity.z);
        if(XZVelocity.magnitude > 6.0f) {
            Vector3 LimitVelocity = XZVelocity.normalized * 6.0f;
            rb.velocity = new Vector3(LimitVelocity.x, rb.velocity.y, LimitVelocity.z);
        }
    }
}
