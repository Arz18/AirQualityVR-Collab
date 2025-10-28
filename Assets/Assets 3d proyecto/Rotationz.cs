using UnityEngine;

public class RotateZ : MonoBehaviour
{
    public float degreesPerSecond = 20f;

    void Update()
    {
        transform.Rotate(0f, 0f, degreesPerSecond * Time.deltaTime, Space.Self);
    }
}
