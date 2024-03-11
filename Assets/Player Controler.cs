using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Start is called before the first frame update
public class PlayerControler : MonoBehaviour
{
    AudioSource _Do, _Re, _Mi, _Fa, _Son, _La, _Si;
    void Start()
    {
        Debug.Log(message:"Start") ;
        _Do = GameObject.FindWithTag("Do").GetComponent<AudioSource>() ;
        _Re = GameObject.FindWithTag("Re").GetComponent<AudioSource>() ;
        _Mi = GameObject.FindWithTag("Mi").GetComponent <AudioSource>() ;
        _Fa = GameObject.FindWithTag("Fa").GetComponent <AudioSource>() ;
        _Son = GameObject.FindWithTag("Son").GetComponent<AudioSource>() ;
        _La = GameObject.FindWithTag("La").GetComponent<AudioSource>() ;
        _Si = GameObject.FindWithTag("Si").GetComponent<AudioSource>() ;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message:"Press A");
            _Do.Play();         
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(message:"Press S") ;
            _Re.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message: "Press D");
            _Mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(message: "Press F");
            _Fa.Play();    
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(message: "Press G");
            _Son.Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log(message:"Press H");
            _La.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(message: "Press J");
            _Si.Play();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log(message: "Press K");
            _Do.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(message: "GetKey D");
        }
    }
}
