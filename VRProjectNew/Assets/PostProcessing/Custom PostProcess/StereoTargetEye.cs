using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void Start()
    {
        Camera.main.stereoTargetEye = StereoTargetEyeMask.Left;
    }
}
