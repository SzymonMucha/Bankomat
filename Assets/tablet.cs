using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tablet : MonoBehaviour
{
    public TextMeshProUGUI tks;
    public bool nie = false;
    public Canvas cvas;
    private Coroutine bruh;
    private Coroutine dwruh;
    private Coroutine kwruh;
    public AudioSource adam;
    public AudioSource szymon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(adam.isPlaying==false)
        {
            StopCoroutine(dwruh);
        }
    }
    public void trans()
    {
        tks.text="";
        dwruh = StartCoroutine(texst(".ɒinɘzbowoԳ .γzbęinɘiq γmυƨ iɔ įɘnżɘlɒn ɘinɒɿdɘbo i oϱ ɘinɒnoʞoq śɒz Ɉƨɘį mɘlɘɔ miowɈ ,]γnzɔiɔɒɿ zƨiwɒlʞ γwɘl[ iʞɒɈɒ ɒn γnɈɒboq Ɉƨɘį ęϱɒwonwóɿ iɔɒɿɈƨ γbϱ żɘinwóɿ Ɉɒmoʞnɒઘ .ɒinɘżɒɿdo zƨɘįυmįγzɿq ,ƨʞɘlʇɘɿ įówɈ zɘzɿq oɈ γzɔ ,γnozƨυłϱo śɘłɒɈƨoz ɘż ,oϱɘɈɒlb oɈ γzɔ ,γɈęinołƨbo śɘɈƨɘį γbӘ .ćśołɒmγzɿɈγw ąįowɈ ɘįγżυz oʞdγzƨ ćśob ɘlɒ ,imɒʞɒɈɒ imγnįɘloʞ bɘzɿq ęiƨ ɘiɔęinołƨɒz ɘįυbowoqƨ υʞold ɘinɒmγzɿɈU .]γnzɔiɔɒɿ zƨiwɒlʞ γwɒɿq[ υɈɒmoʞnɒd υƨoiɔ ɘiɔnɘmom w ɘinlɒɘbi ęiƨ ɔąįɒinɒłƨɒz iʞɒɈɒ oϱɘį ćɒwoɿɒq zƨiƨυm iϱɒwonwóɿ z ɒʞinwiɔɘzɿq ćiɔąɿɈγw γdA .ɒinɘiwɈɿɒmz ɘzƨʞęiw zƨɒm iʞlɒw ɘiƨɒzɔ w ɘż ,įɘizbɿɒd mγɈ ,γmśililɈɘiwśγw ɘį ʞɒį ,ęiƨ įɒiwɒnɒɈƨɒz ɘiИ .ɘidɘiɔ ɒlb śɒz ɘlob ɒn ,υɈɒmoʞnɒd ɒlb ɘzɿóϱ ɒn ,wóʞƨɒq ʜɔγnowɿɘzɔ i ʜɔγwozɔńɒɿɒmoq oinbɘiwoqbo ąɔomoq ɒz ɘnɒwoɈnɘzɘɿqɘɿ ,ɘiɔγż i ęϱɒwonwóɿ ąįowƨ ɘiɔɒm įɒdO .υįod w oϱ zƨɒnoʞoq γbϱ ,ɒnoɔɒłqγw ɘinɒɈƨoz γzbęinɘiq ɒmυƨ ɒnɒbąŻ .ąnzɔγziʇ ćśonwɒɿqƨ ąįowɈ żɘinwóɿ inɘɔo Ɉɒmoʞnɒd zƨɒn żγbϱ ,γɈowʞ įɘnɒzbɒwoɿqw mɘinɘzbɿɘiwɈɒz bɘzɿq ęiƨ įυɈoϱγzɿԳ .ɘinɒɿʞɘ ɒn imγnɒlɈɘiwśγw imɒinɘɔɘloq z ɘinboϱz įυqęɈƨoq ,ɿɘɈnɘ ɒzƨiwɒlʞ υiɔęinʞilʞ oԳ .imɒʞzɔiɔɒɿ γzbęim ęiƨ łɒwobįɒnz įɘnzɔγɿɘmυn γɿυɈɒiwɒlʞ ʞƨiɔγzɿq γdɒ ,ʞɒɈ mɘɈγqoʞ ćɒwolɘɔ ołγd įɘinboϱγwįɒn wóɿɘɈƨɘɈ ʜɔinbɘzɿqoq iiniqo ϱυłbɘW .ɘnɒwoɿɘzγw ɘinɒɈƨoz ɒinɒzbɒwoɿqw ɘloq ɘłɒɔ żɒ ,oɿɘz ęɿʇγɔ įɒʞilʞ ,zƨilγmoq ęiƨ ilśɘႱ .niq zƨiqw i ʜɔin z ąnbɘį źbɒwoɿqW .ɘwoɈγbɘɿʞ γɈɿɒʞ ęiƨ ąįυbįɒnz ɘinoɿɈƨ įɘwɒɿq įɘįowɈ oԳ .Ɉązɿɘiwz ɒlb iϱυłƨdo imɒinɘiwɈɒłυ z ,υɈɒmoʞnɒd oϱɘnƨɘzɔowon mɘqγɈoɈoɿq bɘzɿq zƨioɈƧ,ɘiɔυɿʞɘɿ įɒɈiW"));  
        StopCoroutine(bruh);
        StopCoroutine(dwruh);
        szymon.Stop();
        adam.Play();
        dwruh = StartCoroutine(texst(".ɒinɘzbowoԳ .γzbęinɘiq γmυƨ iɔ įɘnżɘlɒn ɘinɒɿdɘbo i oϱ ɘinɒnoʞoq śɒz Ɉƨɘį mɘlɘɔ miowɈ ,]γnzɔiɔɒɿ zƨiwɒlʞ γwɘl[ iʞɒɈɒ ɒn γnɈɒboq Ɉƨɘį ęϱɒwonwóɿ iɔɒɿɈƨ γbϱ żɘinwóɿ Ɉɒmoʞnɒઘ .ɒinɘżɒɿdo zƨɘįυmįγzɿq ,ƨʞɘlʇɘɿ įówɈ zɘzɿq oɈ γzɔ ,γnozƨυłϱo śɘłɒɈƨoz ɘż ,oϱɘɈɒlb oɈ γzɔ ,γɈęinołƨbo śɘɈƨɘį γbӘ .ćśołɒmγzɿɈγw ąįowɈ ɘįγżυz oʞdγzƨ ćśob ɘlɒ ,imɒʞɒɈɒ imγnįɘloʞ bɘzɿq ęiƨ ɘiɔęinołƨɒz ɘįυbowoqƨ υʞold ɘinɒmγzɿɈU .]γnzɔiɔɒɿ zƨiwɒlʞ γwɒɿq[ υɈɒmoʞnɒd υƨoiɔ ɘiɔnɘmom w ɘinlɒɘbi ęiƨ ɔąįɒinɒłƨɒz iʞɒɈɒ oϱɘį ćɒwoɿɒq zƨiƨυm iϱɒwonwóɿ z ɒʞinwiɔɘzɿq ćiɔąɿɈγw γdA .ɒinɘiwɈɿɒmz ɘzƨʞęiw zƨɒm iʞlɒw ɘiƨɒzɔ w ɘż ,įɘizbɿɒd mγɈ ,γmśililɈɘiwśγw ɘį ʞɒį ,ęiƨ įɒiwɒnɒɈƨɒz ɘiИ .ɘidɘiɔ ɒlb śɒz ɘlob ɒn ,υɈɒmoʞnɒd ɒlb ɘzɿóϱ ɒn ,wóʞƨɒq ʜɔγnowɿɘzɔ i ʜɔγwozɔńɒɿɒmoq oinbɘiwoqbo ąɔomoq ɒz ɘnɒwoɈnɘzɘɿqɘɿ ,ɘiɔγż i ęϱɒwonwóɿ ąįowƨ ɘiɔɒm įɒdO .υįod w oϱ zƨɒnoʞoq γbϱ ,ɒnoɔɒłqγw ɘinɒɈƨoz γzbęinɘiq ɒmυƨ ɒnɒbąŻ .ąnzɔγziʇ ćśonwɒɿqƨ ąįowɈ żɘinwóɿ inɘɔo Ɉɒmoʞnɒd zƨɒn żγbϱ ,γɈowʞ įɘnɒzbɒwoɿqw mɘinɘzbɿɘiwɈɒz bɘzɿq ęiƨ įυɈoϱγzɿԳ .ɘinɒɿʞɘ ɒn imγnɒlɈɘiwśγw imɒinɘɔɘloq z ɘinboϱz įυqęɈƨoq ,ɿɘɈnɘ ɒzƨiwɒlʞ υiɔęinʞilʞ oԳ .imɒʞzɔiɔɒɿ γzbęim ęiƨ łɒwobįɒnz įɘnzɔγɿɘmυn γɿυɈɒiwɒlʞ ʞƨiɔγzɿq γdɒ ,ʞɒɈ mɘɈγqoʞ ćɒwolɘɔ ołγd įɘinboϱγwįɒn wóɿɘɈƨɘɈ ʜɔinbɘzɿqoq iiniqo ϱυłbɘW .ɘnɒwoɿɘzγw ɘinɒɈƨoz ɒinɒzbɒwoɿqw ɘloq ɘłɒɔ żɒ ,oɿɘz ęɿʇγɔ įɒʞilʞ ,zƨilγmoq ęiƨ ilśɘႱ .niq zƨiqw i ʜɔin z ąnbɘį źbɒwoɿqW .ɘwoɈγbɘɿʞ γɈɿɒʞ ęiƨ ąįυbįɒnz ɘinoɿɈƨ įɘwɒɿq įɘįowɈ oԳ .Ɉązɿɘiwz ɒlb iϱυłƨdo imɒinɘiwɈɒłυ z ,υɈɒmoʞnɒd oϱɘnƨɘzɔowon mɘqγɈoɈoɿq bɘzɿq zƨioɈƧ,ɘiɔυɿʞɘɿ įɒɈiW"));  
    
    }
    public void learn()
    {
        if(!nie)
        {
            tks.text="";
            cvas.enabled=true;
            bruh = StartCoroutine(texst("Witaj rekrucie,\nStoisz przed prototypem nowoczesnego bankomatu, z ułatwieniami obsługi dla zwierząt. Po twojej prawej stronie znajdują się karty kredytowe. Wprowadź jedną z nich i wpisz pin. Jeśli się pomylisz, klikaj cyfrę zero, aż całe pole wprowadzania zostanie wyzerowane. Według opinii poprzednich testerów najwygodniej było celować kopytem tak, aby przycisk klawiatury numerycznej znajdował się między raciczkami. Po kliknięciu klawisza enter, postępuj zgodnie z poleceniami wyświetlanymi na ekranie. Przygotuj się przed zatwierdzeniem wprowadzanej kwoty, gdyż nasz bankomat oceni również twoją sprawność fizyczną. Żądana suma pieniędzy zostanie wypłacona, gdy pokonasz go w boju. Obaj macie swoją równowagę i życie, reprezentowane za pomocą odpowiednio pomarańczowych i czerwonych pasków, na górze dla bankomatu, na dole zaś dla ciebie. Nie zastanawiaj się, jak je wyświetliliśmy, tym bardziej, że w czasie walki masz większe zmartwienia. Aby wytrącić przeciwnika z równowagi musisz parować jego ataki zasłaniając się idealnie w momencie ciosu bankomatu [prawy klawisz raciczny]. Utrzymanie bloku spowoduje zasłonięcie się przed kolejnymi atakami, ale dość szybko zużyje twoją wytrzymałość. Gdy jesteś odsłonięty, czy to dlatego, że zostałeś ogłuszony, czy to przez twój refleks, przyjmujesz obrażenia. Bankomat również gdy straci równowagę jest podatny na ataki [lewy klawisz raciczny], twoim celem jest zaś pokonanie go i odebranie należnej ci sumy pieniędzy. \nPowodzenia."));
            szymon.Play();
            adam.Stop();
            nie=true;
        }
        else
        {
            cvas.enabled=false;
            adam.Stop();
            szymon.Stop();
            nie=false;
            StopCoroutine(bruh);
            StopCoroutine(kwruh);
            StopCoroutine(dwruh);
        }
    }
    private IEnumerator texst(string other)
    {
        yield return new WaitForSeconds(2f);
        foreach(char ch in other)
        {
            tks.text+=ch;
            if(ch=='.')
            {
                yield return new WaitForSeconds(0.4f);
                Debug.Log(".");
            }
            else if(ch==',')
            {
                yield return new WaitForSeconds(0.1f);
                Debug.Log(",");
            }
            else
            {
                yield return new WaitForSeconds(0.06f);
            }
        }
        nie=false;
    }
}
