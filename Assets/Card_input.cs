using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card_input : MonoBehaviour
{
    public Karta karta_object;
    public True_enter enter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("giosjofjaiojfipajpi[oa");
        karta_object = other.gameObject.GetComponent(typeof(Karta)) as Karta;
        karta_object.innn();

        enter.set_object(karta_object);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("giosjofjaiojfipajpi[oa");
        karta_object = other.gameObject.GetComponent(typeof(Karta)) as Karta;
        karta_object.outtt();
    }

    // Update is called once per frame
    void Update()
    {

    }
}