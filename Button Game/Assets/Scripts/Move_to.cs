using UnityEngine;
using UnityEngine.UIElements;

public class CubeMover : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public data_humain data;

    private Vector3 position;
    public float speed = 1f;

    private float startTime;
    private float journeyLength;

    private void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(pointA.position, pointB.position);
    }

    private void Update()
    {
        
        float distanceCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distanceCovered / journeyLength;
        transform.position = Vector3.Lerp(pointA.position, pointB.position, fractionOfJourney);

        position = gameObject.transform.position;
        data.Position_humain = position;

        // Pour s'assurer que le cube se déplace de A à B puis de B à A, si besoin
        if (fractionOfJourney >= 1f)
        {
            Vector3 temp = pointA.position;
            pointA.position = pointB.position;
            pointB.position = temp;
            startTime = Time.time;
        }

    }
}
