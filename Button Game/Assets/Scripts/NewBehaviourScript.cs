using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Bool�en pour v�rifier si la touche espace est enfonc�e
    private bool spacePressed = false;

    // Bool�en pour v�rifier si le cube est dans la zone de d�clenchement
    private bool inTriggerZone = false;

    // M�thode appel�e lorsque le cube entre en collision avec la zone de d�clenchement
    private void OnTriggerEnter(Collider other)
    {
        // V�rifie si l'objet en collision est la zone de d�clenchement
        if (other.CompareTag("TriggerZone"))
        {
            // Marque que le cube est dans la zone de d�clenchement
            inTriggerZone = true;
        }
    }

    // M�thode appel�e lorsque le cube quitte la zone de d�clenchement
    private void OnTriggerExit(Collider other)
    {
        // V�rifie si l'objet en collision est la zone de d�clenchement
        if (other.CompareTag("TriggerZone"))
        {
            // Marque que le cube n'est plus dans la zone de d�clenchement
            inTriggerZone = false;
        }
    }

    // M�thode appel�e � chaque frame
    private void Update()
    {
        // V�rifie si la touche espace est enfonc�e ou rel�ch�e
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            spacePressed = false;
        }

        // D�truit le cube si la touche espace n'est pas enfonc�e et que le cube est dans la zone de d�clenchement
        if (!spacePressed && inTriggerZone)
        {
            Destroy(gameObject);
        }
    }
}