using UnityEngine;
using TMPro;

public class GD_PlayerInteract : MonoBehaviour
{
    public Camera PlayerCamera;
    public float InteractionDistance = 4f;
    public GameObject interactionText;
    private GD_InteractObject currentInteractable;

    void Start()
    {
        if (interactionText != null)
        {
            interactionText.SetActive(false); // Hide interaction text at the start
        }
    }

    void Update()
    {
        CheckForInteractable();
        OnInteract(); // Call OnInteract in Update to check for interaction
    }

    private void CheckForInteractable()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, InteractionDistance))
        {
            GD_InteractObject interactableObject = hit.collider.GetComponent<GD_InteractObject>();
            if (interactableObject != null && interactableObject != currentInteractable)
            {
                currentInteractable = interactableObject;
                ShowInteractionText();
            }
        }
        else
        {
            currentInteractable = null;
            interactionText.SetActive(false);
        }
    }

    private void ShowInteractionText()
    {
        if (interactionText != null)
        {
            interactionText.SetActive(true);
            TextMeshProUGUI textComponent = interactionText.GetComponent<TextMeshProUGUI>();
            if (textComponent != null)
            {
                textComponent.text = currentInteractable.GetInteractionText();
            }
        }
    }

    public void OnInteract()
    {
        if (currentInteractable != null &&  Input.GetKeyDown(KeyCode.E))
        {
            // Send a message to the GD_ObjectInteract script
            GD_InteractObject objectInteract = currentInteractable.GetComponent<GD_InteractObject>();
            if (objectInteract != null)
            {
                objectInteract.Interact(); // Call the Interact method directly
            }

            // Uncomment the following line if you want to destroy the object after interaction
            // if (currentInteractable.GetInteractionText() == "porta de sair") Destroy(currentInteractable.gameObject, 2);
        }
    }
}