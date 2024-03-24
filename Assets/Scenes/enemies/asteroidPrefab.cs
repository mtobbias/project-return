using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidPrefab : MonoBehaviour
{
    public float cicle = 1000;
    public int count = 0;
    public float forceMagnitude = 100f; // Magnitude da força aplicada no eixo X

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); // Obtém o componente Rigidbody do objeto

        // Verifica se o Rigidbody existe e adiciona a força no eixo X
        if (rb != null)
        {
            rb.AddForce(Vector3.left * forceMagnitude, ForceMode.Impulse);
        }
    }

    void Update()
    {
        Debug.Log("count: " + count + ", cicle: " + cicle);

        if (count > cicle)
        {
            Destroy(gameObject);
        }

        count++;
    }
}
