using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _Sphere;
    [SerializeField] GameObject _Capsule;
    [SerializeField] GameObject _Cylinder;

    [SerializeField] bool _checkcube;
    [SerializeField] bool _clecksphere;
    [SerializeField] bool _cleckScapsule;
    [SerializeField] bool _cleckcylinder;


    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

        if (_checkcube == false)
        {

            _cube.SetActive(false);
        }
        else
        {
            _cube.SetActive(true);
        }

        if (_clecksphere == false)
        {

            _Sphere.SetActive(false);
        }
        else
        {
            _Sphere.SetActive(true);
        }

        if (_cleckScapsule == false)
        {

            _Capsule.SetActive(false);
        }
        else
        {
            _Capsule.SetActive(true);
        }

        if (_cleckcylinder == false)
        {

            _Cylinder.SetActive(false);
        }
        else
        {
            _Cylinder.SetActive(true);
        }


    }
}
