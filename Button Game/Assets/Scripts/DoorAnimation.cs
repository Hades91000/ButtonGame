using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Booléen pour vérifier si la touche espace est enfoncée
    private bool spacePressed = false;

    // Booléen pour vérifier si l'animation a déjà été lancée
    private bool animationStarted = false;

    // Animation de la porte
    private Animation doorAnimation;

    private void Start()
    {
        // Récupère le composant Animation de la porte
        doorAnimation = GetComponent<Animation>();
    }

    // Méthode appelée à chaque frame
    private void Update()
    {
        // Vérifie si la touche espace est enfoncée ou relâchée
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
            // Si l'animation n'a pas déjà été lancée, lance l'animation
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

        // Si la touche espace est relâchée et que l'animation a été lancée, réinitialise l'animation et le marque comme non lancée
        if (!spacePressed && animationStarted)
        {
            doorAnimation.Rewind();
            animationStarted = false;
        }
    }
}