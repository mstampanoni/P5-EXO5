using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player; // Le joueur à suivre
    public float distance = 5.0f; // Distance par rapport au joueur
    public float height = 2.0f; // Hauteur de la caméra
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
        // Récupère les mouvements de la souris
        yaw += Input.GetAxis("Mouse X") * rotationSpeed;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed;
        pitch = Mathf.Clamp(pitch, -35f, 60f); // Limite la rotation verticale
    }

    void LateUpdate()
    {
        // Position de la caméra par rapport au joueur
        Vector3 targetPosition = player.position - (Quaternion.Euler(pitch, yaw, 0) * Vector3.forward * distance);
        targetPosition.y += height;

        // Déplace la caméra à la position cible
        transform.position = targetPosition;
        // Oriente la caméra vers le joueur
        transform.LookAt(player.position + Vector3.up * height);
    }
}
