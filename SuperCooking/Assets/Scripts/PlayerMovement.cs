using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player
    public Camera playerCamera; // Reference to the camera
    public float mouseSensitivity = 2f; // Sensitivity for mouse movement

    private float rotationY = 0f; // Vertical rotation
    private float rotationX = 0f; // Horizontal rotation

    private void Update()
    {
        // Get input from WASD keys
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float vertical = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow

        // Create a movement vector
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;

        // Move the player
        if (moveDirection.magnitude >= 0.1f)
        {
            // Move the player in the direction they are facing
            Vector3 moveDir = playerCamera.transform.TransformDirection(moveDirection);
            moveDir.y = 0; // Keep the movement on the horizontal plane
            transform.position += moveDir.normalized * moveSpeed * Time.deltaTime;
        }

        // Mouse look
        rotationY += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Clamp vertical rotation

        // Apply rotation
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}