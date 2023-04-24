using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numeros : MonoBehaviour
{
    // Comtroller the speed of Character 
    [SerializeField] int _gStromg;
    [SerializeField] int _gLow;
    [SerializeField] float _gravity;
    [SerializeField] GameObject _bola;
    [SerializeField] Rigidbody _rig;
    [SerializeField] Text _text;


    // Start is called before the first frame update
    void Start()
    {
        _rig.mass=_gravity;
        _gravity = _gravity * 3;
        
        _text.text = "oi"+" " +_gravity;
    }

    // Update is called once per frame
    void Update()
    {
        _rig.mass = _gravity;
        
    }
}
