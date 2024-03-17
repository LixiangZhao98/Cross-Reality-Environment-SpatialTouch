using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ScreenCamControl : MonoBehaviour
{
    public Camera mainCam;
    public Camera screenCam;
    public Transform screen;
    public Transform screenRT; // right top
    public Transform screenLB; // left bottom
    float farClipZ = 1000f;
    Matrix4x4 projectionMatrix;

    private void Start()
    {
        projectionMatrix = screenCam.projectionMatrix;
    }
    private void Update()
    {
        screenCam.transform.position = mainCam.transform.position;
        Quaternion newRotation = Quaternion.LookRotation(screen.forward, screen.up);

        screenCam.transform.rotation = newRotation;
        Vector3 RTcoord = screenCam.transform.InverseTransformPoint(screenRT.position);
        Vector3 LBcoord = screenCam.transform.InverseTransformPoint(screenLB.position);
        Vector3 screencoord = screenCam.transform.InverseTransformPoint(screen.position);
        projectionMatrix.m00 = 2 * LBcoord.z / (RTcoord.x - LBcoord.x);
        projectionMatrix.m02 = (RTcoord.x + LBcoord.x) / (RTcoord.x - LBcoord.x);
        projectionMatrix.m11 = 2 * LBcoord.z / (RTcoord.y - LBcoord.y);
        projectionMatrix.m12 = (RTcoord.y + LBcoord.y) / (RTcoord.y - LBcoord.y);
        projectionMatrix.m22 = -(farClipZ + screencoord.z) / (farClipZ - screencoord.z);
        projectionMatrix.m23 = (-2f * farClipZ * screencoord.z) / (farClipZ - screencoord.z);
        screenCam.projectionMatrix = projectionMatrix;
        screenCam.nearClipPlane = screencoord.z;
        screenCam.farClipPlane = farClipZ;
    }
}
