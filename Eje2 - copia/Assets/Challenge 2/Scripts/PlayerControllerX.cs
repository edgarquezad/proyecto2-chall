using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float espera = 1;
    private float siguiente_disparo= 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >siguiente_disparo )
        {
            siguiente_disparo = Time.time + espera;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
