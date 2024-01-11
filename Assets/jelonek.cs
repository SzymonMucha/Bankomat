using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jelonek : MonoBehaviour
{
    private Image sr;
    public AudioSource ogluszony;
    public Sprite garda;
    public Sprite dol;
    public Sprite lewy;
    public Sprite prawy;
    public int hp = 10;
    public int posture = 10;
    public True_enter enter;
    private bool isLewy = true;
    public bool isParry = false;
    private bool parried = false;
    private bool canBlock = true;
    public bool isBlock = false;
    public bool isAttack = false;
    private bool isStunned = false;
    public paski hp_bar;
    public paski posture_bar;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<Image>();
    }
    public void magiczny_biedron()
    {
        hp = 10;
        posture = 10;
        isLewy = true;
        isParry = false;
        parried = false;
        canBlock = true;
        isBlock = false;
        isAttack = false;
        isStunned = false;
    }
    IEnumerator walka_ruchy()
    {
        if(isLewy)
        {
            sr.sprite = lewy;
            //yield return new WaitForSeconds(50f);
            isLewy = !isLewy;
        }
        else if(!isLewy)
        {
            sr.sprite = prawy;
            //yield return new WaitForSeconds(50f);
            isLewy = !isLewy;
        }
        
        yield return new WaitForSeconds(0.8f);
        sr.sprite = dol;
    }

    IEnumerator parry()
    {
        isParry = true;
        yield return new WaitForSeconds(0.5f);
        isParry = false;
    }

    IEnumerator block_is_can()
    {
        canBlock = false;
        yield return new WaitForSeconds(0.2f);
        canBlock = true;
    }

    IEnumerator stunned()
    {
        ogluszony.Play();
        isStunned = true;
        isAttack = false;
        canBlock = false;
        yield return new WaitForSeconds(0.25f);
        for(int i = 1; i<=10; i++)
        {
            posture = i;
            yield return new WaitForSeconds(0.1f);
        }
        isAttack = false;
        canBlock = true;  
        isStunned = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if(enter.isFight)
        {
            posture_bar.sr.enabled = true;
            hp_bar.sr.enabled = true;
            sr.enabled = true;
        }
        else
        {
            posture_bar.sr.enabled = false;
            hp_bar.sr.enabled = false;
            sr.enabled = false;
        }
        if(Input.GetMouseButtonDown(0) && !isStunned && !isAttack)
        {
            isAttack = true;
            StartCoroutine(walka_ruchy());
        }
        if(Input.GetMouseButton(1) && canBlock)
        {
            sr.sprite = garda;
            isBlock = true;
            if(!isParry && !parried)
            {
                parried = true;
                StartCoroutine(parry());
            }
        }
        if(Input.GetMouseButtonUp(1) && canBlock)
        {
            parried = false;
            isBlock = false;
            StartCoroutine(block_is_can());
            sr.sprite = dol;
        }
        if(posture == 0 && !isStunned)
        {
            sr.sprite = dol;
            StartCoroutine(stunned());
        }
        
        posture_bar.transform.localScale = new Vector2(10*posture, 15);
        hp_bar.transform.localScale = new Vector2(10*hp, 15);
    }
}