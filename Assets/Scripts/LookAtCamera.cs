using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        // Find the main camera in the scene
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (mainCamera != null)
        {
            // Get the direction from the camera to the object
            Vector3 awayFromCameraDirection = transform.position - mainCamera.transform.position;

            // Make the object face away from the camera
            transform.rotation = Quaternion.LookRotation(awayFromCameraDirection, Vector3.up);
        }
    }
}