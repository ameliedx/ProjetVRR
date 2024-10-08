using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRMovement : MonoBehaviour
{
    public InputActionProperty leftHandMove; // Pour le d�placement (joystick gauche)
    public InputActionProperty rightHandTurn; // Pour la rotation (joystick droit)

    public float moveSpeed = 1.5f; // Vitesse de d�placement
    public float turnSpeed = 45f; // Vitesse de rotation (45 degr�s)

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Gestion du d�placement avant/arri�re et gauche/droite
        Vector2 inputMove = leftHandMove.action.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(inputMove.x, 0, inputMove.y);
        moveDirection = transform.TransformDirection(moveDirection); // Convertir en direction relative au joueur
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        // Gestion de la rotation � gauche/droite (joystick droit)
        Vector2 inputTurn = rightHandTurn.action.ReadValue<Vector2>();
        float rotationAngle = inputTurn.x * turnSpeed * Time.deltaTime; // Rotation avec joystick droit
        transform.Rotate(Vector3.up, rotationAngle);
    }
}