using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controladortexto : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _Sphere;
    [SerializeField] GameObject _Capsule;
    [SerializeField] GameObject _Cylinder;
    [SerializeField]  string _texto;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (_texto == "cube")
        {
            _cube.SetActive(true);
        }
        else
        {
            _cube.SetActive(false);
        }
        if (_texto == "Sphere")
        {
            _Sphere.SetActive(true);
        }
        else
        {
            _Sphere.SetActive(false);
        }

        if (_texto == "Capsule")
        {
            _Capsule.SetActive(true);
        }
        else
        {
            _Capsule.SetActive(false);
        }
        if (_texto == "Cylinder")
        {
            _Cylinder.SetActive(true);
        }
        else
        {
            _Cylinder.SetActive(false);
        }

    }
}
