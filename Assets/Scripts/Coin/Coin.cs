using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float jumpForce = 5f;
    private bool isGrounded = false;

    void Start()
    {

    }

    void Update()
    {
        if (((int)Time.deltaTime % 17) == 0 && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGrounded = true;
        }
    }
}
