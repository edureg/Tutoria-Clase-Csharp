using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicOperations : MonoBehaviour
{
    public int primerValor;
    public const int segundoValor = 2;
    int resultadoOperaciones;
    // Start is called before the first frame update
    void Start()
    {
        resultadoOperaciones = primerValor % segundoValor;
        Debug.Log("Resultado de la Operación = " + resultadoOperaciones);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
