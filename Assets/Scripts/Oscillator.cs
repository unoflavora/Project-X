using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;
    [SerializeField][Range(0, 1)] float movementFactor;
    [SerializeField] float period = 2f;

    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; }
        const float tau = Mathf.PI * 2;

        float cycles = Time.time / period;
        float rawSinWave = Mathf.Sin(cycles * tau); // dari -1 ke 1

        movementFactor = (rawSinWave + 1f) / 2; // biar dari -2 ke 2, lalu diskala ke -1 ke 1 lagi

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
