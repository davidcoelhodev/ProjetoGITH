using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicionais : MonoBehaviour
{
    float _f1;
    float _f2;

    [SerializeField] int _i1;
    [SerializeField] int _i2;

    [SerializeField] string _t1;
    [SerializeField] string _t2;

    [SerializeField] bool _b1;
    [SerializeField] bool _b2;

    // > Maior 
    // < menor 
    // >= maior ou igual 
    // <= menor ou igual 
    // != diferente 
    // ==igual 
    // &&
    // || 


    // Start is called before the first frame update
    void Start()
    {

        // se a _t1 for igual a multiplicação 
        // mulpliticação _1 com a _i2 
        // se nao , somar a i1 com a _i2;


        if (_t1 == "Multiplicação")
        {

            Debug.Log(_i1 * _i2);
        }
        else 
        {
            Debug.Log( _i1 + _i2);
        }


        

        _i1 = _i2;
        
        if (_i1==1) {   // SE _i1 for igual a 1 
            Debug.Log("FASE 1 Liberada");

        }

        else // se não for bloqueada  
        {
            Debug.Log(" fase 1 bloqueada");
        }

        if (_i1 == 2)
        {
            _t1 = "PASSAGEM LIBERADA";

        }
        else 
        {
            _t1 = "PASSAGEM BLOQUEADA";
           
        }
        Debug.Log(_t1);

        // SE A _I1 for igual a 2 
        // a _t1 escreve passagem liberada 
        // se não _t1 passagem bloqueada 


        if (_t1 == _t2 && _b1==true)
        {
            Debug.Log("ENTRA NA FASE");

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
