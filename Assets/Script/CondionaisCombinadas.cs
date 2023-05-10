using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondionaisCombinadas : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] Rigidbody _cubRig;
    [SerializeField] BoxCollider _cubebox; 
    // C
    [SerializeField] GameObject _Sphere;
    [SerializeField] Rigidbody _SphereRing;
    
    //  PUXANDO COMPONETE 
    [SerializeField] GameObject _Capsule;
    [SerializeField] Rigidbody __CapsuleRing;

    [SerializeField] GameObject _Cylinder;
    [SerializeField] Rigidbody _CylinderRing;

    [SerializeField] string _text;
    [SerializeField] float _number;
    [SerializeField] bool _check;

    /// tabela logica de ou 

    // Start is called before the first frame update
    void Start()
    {
        _cubebox = _cube.GetComponent<BoxCollider>();
        if (_cubebox != null)
        {
            _cubebox.enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (_check== true&& _number==1)
        {
            _cube.SetActive(true);
           // _cubRig.use
             //   Gravity = false;
            _cubRig.isKinematic = true;
        }
        else if ( _check== true && _number==2)
        {
            _cube.SetActive(false);
            _Sphere.SetActive(true);
            _Capsule.SetActive(false);
            _Cylinder.SetActive(false);
        }
        


    }
}
