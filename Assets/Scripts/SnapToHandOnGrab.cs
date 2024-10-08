using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapToHandOnGrab : MonoBehaviour
{
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;
    public Transform handPosition; // R�f�rence � l'objet vide pr�s de la cam�ra
    private bool isGunHeld = false;

    private void OnEnable()
    {
        grabInteractable.selectEntered.AddListener(OnGrab);
    }

    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        // Positionne le pistolet à la bonne orientation lorsque saisi
        transform.rotation = Quaternion.Euler(0, 0, 0); // Ajuste les valeurs selon la bonne orientation
        transform.localPosition = Vector3.zero; // Ajuste si nécessaire
        isGunHeld = true;
        Debug.Log("Pistolet saisi !");
    }
}
