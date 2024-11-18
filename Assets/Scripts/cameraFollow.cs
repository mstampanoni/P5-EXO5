using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player; // Le joueur � suivre
    public float distance = 5.0f; // Distance par rapport au joueur
    public float height = 2.0f; // Hauteur de la cam�ra
    public float rotationSpeed = 5.0f; // Vitesse de rotation avec la souris

    private float yaw; // Axe horizontal de rotation
    private float pitch; // Axe vertical de rotation

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Verrouille le curseur
        Cursor.visible = false; // Cache le curseur
    }

    void Update()
    {
        // R�cup�re les mouvements de la souris
        yaw += Input.GetAxis("Mouse X") * rotationSpeed;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed;
        pitch = Mathf.Clamp(pitch, -35f, 60f); // Limite la rotation verticale
    }

    void LateUpdate()
    {
        // Position de la cam�ra par rapport au joueur
        Vector3 targetPosition = player.position - (Quaternion.Euler(pitch, yaw, 0) * Vector3.forward * distance);
        targetPosition.y += height;

        // D�place la cam�ra � la position cible
        transform.position = targetPosition;
        // Oriente la cam�ra vers le joueur
        transform.LookAt(player.position + Vector3.up * height);
    }
}
