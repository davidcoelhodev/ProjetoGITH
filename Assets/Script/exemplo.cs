using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exemplo : MonoBehaviour
{

    [SerializeField] int _number;
    [SerializeField] string _text;
    [SerializeField] string _text2 = "nao quero pizza";
    [SerializeField] bool _check;
    [SerializeField] float _fnumber;
   

   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Variavel number is: " + _number);
        _number = 2;
        Debug.Log("New number value is: " + _number);


        _text = "CADE A PIZZA IVO";
        Debug.Log(_text);

        _text = " " + _number;

        _text = _text2;
        Debug.Log(_text);
        _check = true;
        Debug.Log("IVO "+_check);

    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("IVO " + _check);
    }
}
