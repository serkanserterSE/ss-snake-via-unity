using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    float speed = 1f;

    public float GetSpeed()
    {
        return speed;
    }

    public void IncreaseSpeed()
    {
        speed += 0.2f;
    }

    public void DecreaseSpeed()
    {
        speed -= 0.2f;
    }
}
