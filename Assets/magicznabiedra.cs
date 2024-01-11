using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicznabiedra : MonoBehaviour
{
    public Karta[] karty;
    public bangomat bank;
    public jelonek jelen;
    public SpriteRenderer[] sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void biedra()
    {
        foreach (Karta k in karty)
        {
            k.magiczny_biedron();
        }
        foreach (SpriteRenderer s in sr)
        {
            s.enabled=true;
        }
        bank.magiczny_biedron();
        jelen.magiczny_biedron();
    }
    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
    }
}
