using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorNumero : MonoBehaviour
{

    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _Sphere;
    [SerializeField] GameObject _Capsule;
    [SerializeField] GameObject _Cylinder;
    [SerializeField] int _numero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_numero == 1)
        {

            _cube.SetActive(true);
        }
       

        else if (_numero == 2)
        {

            _Sphere.SetActive(true);
        }
       
        else if (_numero == 3)
        {

            _Capsule.SetActive(true);
        }
        else if (_numero == 4)
        {

            _Cylinder.SetActive(true);
        }



        else if (_numero < 1)
        {
            _cube.SetActive(false);
            _Sphere.SetActive(false);
            _Capsule.SetActive(false);
            _Cylinder.SetActive(false);

         
        }

        else 
        {
            _cube.SetActive(true);
            _Sphere.SetActive(true);
            _Capsule.SetActive(true);
            _Cylinder.SetActive(true);
        }

    }
    }

