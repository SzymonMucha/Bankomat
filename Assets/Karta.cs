using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karta : MonoBehaviour
{
    public string nazwa;
    public SpriteRenderer sr;
    public Sprite polowa;
    public Sprite calosc;
    public True_enter te;
    private bool blok = false;
    private Transform t;
    private Vector2 vector;
    
    public void innn()
    {
        StartCoroutine(waaaait());
    }
    public void magiczny_biedron()
    {
        t.position=vector;
        sr.enabled=true;
    }
    
    IEnumerator waaaait()
    {
        sr.sprite = polowa;
        t.position = new Vector2(0.53f, -0.606f);
        blok = true;
        yield return new WaitForSeconds(2f);
        if(nazwa != "American")
        {
            blok = true;
        }
        else
        {
            blok = false;
        }
    }
    public void outtt()
    {
        blok=false;
        sr.sprite = calosc;
    }
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = calosc;
        t = GetComponent<Transform>();
        vector=t.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(blok && te.isFight)
        {
            sr.enabled = false;
        }
    }

    void OnMouseOver()
    {
        if(!blok)
        {
            if(Input.GetMouseButton(0))
            {
                Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mouseCursorPos;
            }
        }
    }
}
