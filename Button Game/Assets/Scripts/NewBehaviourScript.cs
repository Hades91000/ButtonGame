using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Booléen pour vérifier si la touche espace est enfoncée
    private bool spacePressed = false;

    // Booléen pour vérifier si le cube est dans la zone de déclenchement
    private bool inTriggerZone = false;

    // Méthode appelée lorsque le cube entre en collision avec la zone de déclenchement
    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision est la zone de déclenchement
        if (other.CompareTag("TriggerZone"))
        {
            // Marque que le cube est dans la zone de déclenchement
            inTriggerZone = true;
        }
    }

    // Méthode appelée lorsque le cube quitte la zone de déclenchement
    private void OnTriggerExit(Collider other)
    {
        // Vérifie si l'objet en collision est la zone de déclenchement
        if (other.CompareTag("TriggerZone"))
        {
            // Marque que le cube n'est plus dans la zone de déclenchement
            inTriggerZone = false;
        }
    }

    // Méthode appelée à chaque frame
    private void Update()
    {
        // Vérifie si la touche espace est enfoncée ou relâchée
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            spacePressed = false;
        }

        // Détruit le cube si la touche espace n'est pas enfoncée et que le cube est dans la zone de déclenchement
        if (!spacePressed && inTriggerZone)
        {
            Destroy(gameObject);
        }
    }
}