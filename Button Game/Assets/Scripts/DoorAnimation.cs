using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Bool�en pour v�rifier si la touche espace est enfonc�e
    private bool spacePressed = false;

    // Bool�en pour v�rifier si l'animation a d�j� �t� lanc�e
    private bool animationStarted = false;

    // Animation de la porte
    private Animation doorAnimation;

    private void Start()
    {
        // R�cup�re le composant Animation de la porte
        doorAnimation = GetComponent<Animation>();
    }

    // M�thode appel�e � chaque frame
    private void Update()
    {
        // V�rifie si la touche espace est enfonc�e ou rel�ch�e
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
            // Si l'animation n'a pas d�j� �t� lanc�e, lance l'animation
            if (!animationStarted)
            {
                doorAnimation.Play();
                animationStarted = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            spacePressed = false;
        }

        // Si la touche espace est rel�ch�e et que l'animation a �t� lanc�e, r�initialise l'animation et le marque comme non lanc�e
        if (!spacePressed && animationStarted)
        {
            doorAnimation.Rewind();
            animationStarted = false;
        }
    }
}