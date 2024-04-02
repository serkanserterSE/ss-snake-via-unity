using UnityEngine;

public class CameraFallowObject : MonoBehaviour
{
    private GameObject playerObject;
    private GameObject cameraObject;
    [SerializeField] float speedFactor = 10f;


    private void Awake()
    {

    }

    void Start()
    {
        playerObject = GameObject.Find("PlayerObject");
        cameraObject = GameObject.Find("MainCamera");
    }


    void Update()
    {
        var position = playerObject.transform.position;
        var vector = new Vector3(position.x + 50f, position.y + 50f, position.z);
        cameraObject.transform.position = Vector3.Lerp(cameraObject.transform.position, vector, Time.deltaTime * speedFactor);

    }
}
