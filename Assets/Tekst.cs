using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tekst : MonoBehaviour
{
    public TextMeshProUGUI komunikat; 
    public int[] liczba = new int[4];
    public int wyswietlana;
    public True_enter te;
    private TextMeshProUGUI tekst;
    public AudioSource beep;
    public bool pauza;
    // Start is called before the first frame update
    void Start()
    {
        liczba[0]=0;
        liczba[1]=0;
        liczba[2]=0;
        liczba[3]=0;
        tekst = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(wyswietlana<10)
        {
            tekst.text="      "+wyswietlana.ToString();
        }
        else if(wyswietlana<100)
        {
            tekst.text="    "+wyswietlana.ToString();
        }
        else if(wyswietlana<1000)
        {
            tekst.text="  "+wyswietlana.ToString();
        }
        else
        {
            tekst.text=wyswietlana.ToString();
        }
        if(te.isFight)
        {
            tekst.text = "";
        }
    }
    public void Uliczbienie(int number)
    {
        liczba[0]=liczba[1];
        liczba[1]=liczba[2];
        liczba[2]=liczba[3];
        liczba[3]=number;
        wyswietlana=liczba[0]*1000+liczba[1]*100+liczba[2]*10+liczba[3];
        beep.Play();
    }
}