using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // V�rifier si l'objet qui est entr� dans la zone a le tag "citizen_b"
        if (other.CompareTag("citizen_b"))
        {
            // Faire dispara�tre l'objet
            Destroy(other.gameObject);
        }
    }
}
