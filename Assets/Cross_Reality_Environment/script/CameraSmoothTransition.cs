using UnityEngine;

public class CameraSmoothTransition : MonoBehaviour
{
    public Transform target; // The target transform to follow. Assign in the Inspector.
    public float positionSmoothSpeed = 0.125f; // Adjust this value to make the position transition faster or slower
    public float rotationSmoothSpeed = 0.125f; // Adjust this value to make the rotation transition faster or slower

    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            // Smoothly interpolate the camera's position towards the target position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, target.position, positionSmoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            // Smoothly interpolate the camera's rotation towards the target rotation
            Quaternion smoothedRotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSmoothSpeed * Time.deltaTime);
            transform.rotation = smoothedRotation;
        }

    }
}
