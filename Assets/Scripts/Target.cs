using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject explosionEffect; // Préfabriqué de l'explosion

    void OnCollisionEnter(Collision collision)
    {
        // Vérifie si la collision vient d'une balle
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Crée l'effet d'explosion à la position de la cible
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            // Désactive ou détruit la cible
            Destroy(gameObject); // Ou utilisez gameObject.SetActive(false); si vous voulez le réutiliser plus tard
        }
    }
}
