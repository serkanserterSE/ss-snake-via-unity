using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private float jumpForce = 10f;
    private bool isGrounded = false;
    private GameObject playerObject;
    void Start()
    {
        playerObject = GameObject.Find("PlayerObject");
    }

    void Update()
    {
        if (playerObject.transform.position.y <= 2.5) isGrounded = true;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            isGrounded = false;
        }
    }
}
