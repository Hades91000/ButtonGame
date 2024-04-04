using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Vérifier si l'objet qui est entré dans la zone a le tag "citizen_b"
        if (other.CompareTag("Player"))
        {
            // Faire disparaître l'objet
            Destroy(other.gameObject);
        }
    }
}
