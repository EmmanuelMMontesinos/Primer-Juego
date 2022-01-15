using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    float altura = 1.71f;
    float peso = 100f;
    float imc;

    // Start is called before the first frame update
    void Start()
    {
        imc = peso / (altura * altura);
        Debug.Log(imc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
