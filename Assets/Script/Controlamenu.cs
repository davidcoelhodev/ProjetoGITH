using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlamenu : MonoBehaviour
{
    [SerializeField] GameObject _painel_Iniciar;
    [SerializeField] GameObject _painel_carregar;
    [SerializeField] GameObject _painel_person;

    public void AtivarPainelIniciar()
    {
        _painel_Iniciar.SetActive(true);
        _painel_carregar.SetActive(false);
        _painel_person.SetActive(false);
    }
    public void AtivarPainelcarregar()
    {
        _painel_Iniciar.SetActive(false);
        _painel_carregar.SetActive(true);
        _painel_person.SetActive(false);
    }
    public void AtivarPainelperson()
    {
        _painel_Iniciar.SetActive(false);
        _painel_carregar.SetActive(false);
        _painel_person.SetActive(true);
    }

    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }  */
}
