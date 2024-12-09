using UnityEngine;
using UnityEngine.InputSystem;

public class Camera : MonoBehaviour
{

    public float sensibilidade = 2.0f;

    private float rotacaoX = 0f;
    private float rotacaoY = 0f;
    public Transform camera;
    public Vector2 MousePosition;

    float x;
    float y;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloqueia o cursor
        Cursor.visible = false; // Esconde o cursor
    }

    void Update()
    {
            
        float mouseX = MousePosition.x * sensibilidade * Time.deltaTime;
        float mouseY = MousePosition.y * sensibilidade * Time.deltaTime;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f); 

        rotacaoY += mouseX;

        camera.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    void OnLook(InputValue value)
    {
        MousePosition = value.Get<Vector2>();
    }
}