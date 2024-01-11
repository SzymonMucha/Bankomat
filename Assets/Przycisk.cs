using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przycisk : MonoBehaviour
{
    public Tekst skrypt;
    public int wartosc;
    private SpriteRenderer sr;
    public True_enter te;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(te.isFight)
        {  
          sr.enabled = false;
        }
    }
    
    void OnMouseOver()
    {
      if(Input.GetMouseButtonDown(0))
      {
        skrypt.Uliczbienie(wartosc);
      }
    }
}
