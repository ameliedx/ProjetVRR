using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Transform pointA; // Point de d�part
    public Transform pointB; // Point d'arriv�e
    public Transform controlPoint; // Point de contr�le pour la courbe

    public float duration = 2f; // Dur�e de l'animation

    // Calcule un point sur la courbe de B�zier
    public Vector3 GetPoint(float t)
    {
        return (1 - t) * (1 - t) * pointA.position + 
               2 * (1 - t) * t * controlPoint.position + 
               t * t * pointB.position;
    }

    // Affiche la courbe dans l'�diteur
    private void OnDrawGizmos()
    {
        if (pointA != null && pointB != null && controlPoint != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(pointA.position, controlPoint.position);
            Gizmos.DrawLine(controlPoint.position, pointB.position);

            for (float t = 0; t <= 1; t += 0.1f)
            {
                Gizmos.DrawSphere(GetPoint(t), 0.05f);
            }
        }
    }
}
