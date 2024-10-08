using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject explosionEffect; // Pr�fabriqu� de l'explosion

    void OnCollisionEnter(Collision collision)
    {
        // V�rifie si la collision vient d'une balle
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Cr�e l'effet d'explosion � la position de la cible
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            // D�sactive ou d�truit la cible
            Destroy(gameObject); // Ou utilisez gameObject.SetActive(false); si vous voulez le r�utiliser plus tard
        }
    }
}
