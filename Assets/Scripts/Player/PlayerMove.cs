using UnityEngine;

public class PlyerMove : MonoBehaviour
{
    private bool isGrounded = true;
    public float moveVelocity = 10f;
    private GameObject playerObject;
    private Vector3 lastMove;

    void Start()
    {
        playerObject = GameObject.Find("PlayerObject");
    }

    void Update()
    {
        if (playerObject.transform.position.y <= 2.5f) isGrounded = true;
        else isGrounded = false;

        if (isGrounded)
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveVelocity, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveVelocity);
            transform.Translate(move, Space.Self);
            lastMove = move;
        }
        else
        {
            transform.Translate(lastMove, Space.Self);
        }
    }
}
