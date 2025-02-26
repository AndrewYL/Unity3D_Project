using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Блокируем курсор в центре экрана
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Ограничиваем наклон камеры

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Вместо `playerBody.Rotate(...)` используем прямое изменение поворота
        playerBody.transform.rotation *= Quaternion.Euler(0f, mouseX, 0f);
    }
}