using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eme : MonoBehaviour
{
    public float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void Update()
    {
        // Lógica de movimento aqui
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
    }
}
