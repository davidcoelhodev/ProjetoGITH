using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texto : MonoBehaviour
{
    // Function to name Player name in the Menu UI
    [SerializeField] string _nome = "steve";
    [SerializeField] string _sobrenome = "Butter";
    [SerializeField] string _nomecompleto;
    [SerializeField] Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        _nome = "jhon";
        _nomecompleto =  _nome + " " + "de" + " " + _sobrenome;
        _text.text = _nome;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
