using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class True_enter : MonoBehaviour
{
    int temp;
    int czas;
    public Tekst tekst;
    public Karta karta_rodzaj;
    public AudioSource beep;
    private SpriteRenderer sr;
    private bool pauza;
    private bool isKwotaIn = false;
    public int state;
    public bool isFight = false;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        state=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFight)
        {
            sr.enabled = false;
        }
    }

    IEnumerator unpauza()
    {
        yield return new WaitForSeconds(2f);
        pauza=false;
        tekst.pauza=false;
    }

    /*IEnumerator komunikat()
    {
        tekst.komunikat.text = "Walczysz o " + tekst.wyswietlana;
        yield return new WaitForSeconds(2f);
        
    }*/

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(!pauza)
            {
                beep.Play();
                if(isKwotaIn)
                {
                    state=tekst.liczba[0]*1000+tekst.liczba[1]*100+tekst.liczba[2]*10+tekst.liczba[3];
                    tekst.liczba[0] = 0;
                    tekst.liczba[1] = 0;
                    tekst.liczba[2] = 0;
                    tekst.liczba[3] = 0;
                    tekst.wyswietlana = 0;
                    isFight = true;
                }
                if(tekst.wyswietlana == 1234 && karta_rodzaj.nazwa == "Visa" && !isKwotaIn)
                {
                    tekst.komunikat.text = "Podaj kwotę do wypłaty.";
                    isKwotaIn = true;
                    tekst.liczba[0] = 0;
                    tekst.liczba[1] = 0;
                    tekst.liczba[2] = 0;
                    tekst.liczba[3] = 0;
                    tekst.wyswietlana = 0;
                }    
                else if(tekst.wyswietlana != 4321 && karta_rodzaj.nazwa == "Mastercard" && !isKwotaIn)
                {
                    tekst.komunikat.text = "Nieprawidłowy pin, spróbuj ponownie";
                    tekst.liczba[0] = 0;
                    tekst.liczba[1] = 0;
                    tekst.liczba[2] = 0;
                    tekst.liczba[3] = 0;
                    tekst.wyswietlana = 0;
                }
                else if(tekst.wyswietlana != 1234 && karta_rodzaj.nazwa == "Visa" && !isKwotaIn)
                {
                    tekst.komunikat.text = "Nieprawidłowy pin, spróbuj ponownie";
                    tekst.liczba[0] = 0;
                    tekst.liczba[1] = 0;
                    tekst.liczba[2] = 0;
                    tekst.liczba[3] = 0;
                    tekst.wyswietlana = 0;
                }    
                else if(tekst.wyswietlana == 4321 && karta_rodzaj.nazwa == "Mastercard" && !isKwotaIn)
                {
                    tekst.komunikat.text = "Podaj kwotę do wypłaty.";
                    tekst.liczba[0] = 0;
                    tekst.liczba[1] = 0;
                    tekst.liczba[2] = 0;
                    tekst.liczba[3] = 0;
                    tekst.wyswietlana = 0;
                    isKwotaIn = true;
                }
                else if(karta_rodzaj.nazwa == "American" && !isKwotaIn)
                {
                    tekst.komunikat.text = "Zła karta, wprowadź inną.";
                }
                pauza=true;
                tekst.pauza=true;
                StartCoroutine(unpauza());
            }
        }
    }

    public void set_object(Karta other)
    {
        karta_rodzaj=other;
    }
}
