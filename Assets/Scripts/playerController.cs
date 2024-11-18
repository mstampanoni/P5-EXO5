using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

[RequireComponent(typeof(Rigidbody), typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    public Transform cameraTransform;

    [Header("Movement Settings")]
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    public float crouchSpeed = 2.5f;
    public float jumpForce = 5f;

    private Vector2 movementInput;
    private bool isSprinting = false;
    private bool isCrouching = false;
    private float currentSpeed;

    [Header("Camera Settings")]
    public float lookSensitivity = 0.15f;
    private Vector2 cameraInput;
    public float normalFOV = 60f;
    public float aimFOV = 40f;
    private float xRotation = 0f;
    private Camera playerCamera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rb.freezeRotation = true;

        currentSpeed = walkSpeed;

        Collider[] childColliders = GetComponentsInChildren<Collider>();
        foreach (Collider collider in childColliders)
        {
            collider.gameObject.tag = "Player";
        }

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        playerCamera = cameraTransform.GetComponent<Camera>();
        playerCamera.fieldOfView = normalFOV;
    }

    private void Update()
    {
        HandleCameraMovement();
        UpdateAnimatorParameters();
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    public void OnMovementAction(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        bool isMoving = movementInput != Vector2.zero;
        animator.SetBool("Moving", isMoving);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetBool("Jumping", true);
        }
        if (context.canceled)
        {
            animator.SetBool("Jumping", false);
        }
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isCrouching = !isCrouching;
            currentSpeed = isCrouching ? crouchSpeed : walkSpeed;
            animator.SetBool("Crouching", isCrouching);
        }
        else if (context.canceled)
        {
            animator.SetBool("Crouching", false);
        }
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        isSprinting = context.performed;
        currentSpeed = isSprinting ? sprintSpeed : walkSpeed;
        animator.SetBool("Running", isSprinting);
    }

    public void OnCameraMovement(InputAction.CallbackContext context)
    {
        cameraInput = context.ReadValue<Vector2>();
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            animator.SetBool("Aiming", true);
            playerCamera.fieldOfView = aimFOV;
        }
        else if (context.canceled)
        {
            animator.SetBool("Aiming", false);
            playerCamera.fieldOfView = normalFOV;
        }
    }

    private void HandleMovement()
    {
        Vector3 moveDirection = transform.right * movementInput.x + transform.forward * movementInput.y;
        Vector3 moveVelocity = moveDirection.normalized * currentSpeed;
        rb.velocity = new Vector3(moveVelocity.x, rb.velocity.y, moveVelocity.z);
    }

    private void HandleCameraMovement()
    {
        xRotation -= cameraInput.y * lookSensitivity;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        float yRotation = cameraInput.x * lookSensitivity;
        transform.Rotate(Vector3.up * yRotation);
        cameraTransform.rotation = Quaternion.Euler(cameraTransform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
    }

    private void UpdateAnimatorParameters()
    {
        bool isIdle = !animator.GetBool("Moving") && !animator.GetBool("Running");
        animator.SetBool("Idle", isIdle);
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
