using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class CameraScript : MonoBehaviour
{
    public Camera PlayerCamera;
    public float sensitivity = 2.0f;

    private float rotationX = 0f;
    private float rotationY = 0f;
    public Transform MyCamera;
    public Vector2 MousePosition;
    public GameObject interactionText;
    private GD_InteractObject currentInteractable;
    public float interactionDistance = 3f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
        Cursor.visible = false; // Hide the cursor
    }

    void Update()
    {
        HandleMouseLook();
        HandleInteraction();
    }

    private void HandleMouseLook()
    {
        float mouseX = MousePosition.x * sensitivity * Time.deltaTime;
        float mouseY = MousePosition.y * sensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); 

        rotationY += mouseX;

        MyCamera.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void HandleInteraction()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(MousePosition); // Create a ray from the camera
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            GD_InteractObject interactableObject = hit.collider.GetComponent<GD_InteractObject>();
            if (interactableObject != null && interactableObject != currentInteractable)
            {
                currentInteractable = interactableObject;
                interactionText.SetActive(true);
                TextMeshProUGUI textComponent = interactionText.GetComponent<TextMeshProUGUI>();
                
                if (textComponent != null)
                {
                    textComponent.text = currentInteractable.GetInteractionText(); // Show interaction text
                }
            }
        }
        else
        {
            currentInteractable = null;
            interactionText.SetActive(false);
        }
    }

    void OnLook(InputValue value)
    {
        MousePosition = value.Get<Vector2>();
    }
}