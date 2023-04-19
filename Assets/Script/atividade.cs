using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atividade : MonoBehaviour
{
    [SerializeField] string _person1= "jogador";
    [SerializeField] string _resultado2  ;
    [SerializeField] string _person3 ;



    // declarar 3 class de texto 
    // inplementar valor somente na 1º
    // alterar a 1º variavel 


    // na função smart 
    // comcatenar a 1 e 2 na 3 variavel 


    // Start is called before the first frame update
    void Start()
    {
        _resultado2= "MVP";
        _person3= _person1 + " " +_resultado2 ;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
