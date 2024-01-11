using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class bangomat : MonoBehaviour
{
    public AudioSource blok;
    public AudioSource uderzenie;
    public AudioSource parowanie;
    public AudioSource wiatr;
    public AudioSource ogluszony;
    public AudioSource MORTALKOMBAT;
    private SpriteRenderer sr;
    public Sprite garda;
    public Sprite dol;
    public Sprite lewy;
    public Sprite prawy;
    public Sprite unrestrictedsubmarinewarfare;
    public int hp = 1;
    public int posture = 1;
    public jelonek jelon;
    public True_enter enter;
    public bool canAttack = true;
    public bool isParry = false;
    public bool canBlock = true;
    public bool isBlock = false;
    public bool isAttack = false;
    public bool isStunned = false;
    public paski hp_bar;
    public paski posture_bar;
    public VideoPlayer video;
    public VideoPlayer you_died;
    private Coroutine atak_cou;
    public magicznabiedra mag;
    public TextMeshProUGUI stan;
    public int konta;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        konta=0;
    }
    public void magiczny_biedron()
    {
        hp = 1;
        posture = 1;
        canAttack = true;
        isParry = false;
        canBlock = true;
        isBlock = false;
        isAttack = false;
        isStunned = false;
        sr.sprite=unrestrictedsubmarinewarfare;
    }
    IEnumerator stunned()
    {
        ogluszony.Play();
        canAttack = false;
        canBlock = false;
        yield return new WaitForSeconds(4f);
        for(int i = 1; i<=1; i++)
        {
            posture = i;
            yield return new WaitForSeconds(0.1f);
        }
        canAttack = true;
        canBlock = true;  
        isStunned = false; 
    }

    IEnumerator attackdelay()
    {
        yield return new WaitForSeconds(Random.Range(3f, 5f));
        canAttack = true;
    }

    IEnumerator attack(int com)
    { 
        if(com == 0)
        {
            //wzór
            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = lewy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(0.5f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = lewy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(1.5f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = prawy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
        }
        else if(com == 1)
        {
            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = prawy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(1.5f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = lewy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(0.5f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = lewy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
        }
        else if(com == 2)
        {
            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = lewy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(4f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = prawy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(0.5f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = lewy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
            yield return new WaitForSeconds(0.5f);

            wiatr.Play();
            yield return new WaitForSeconds(0.5f);
            sr.sprite = prawy;
            yield return new WaitForSeconds(0.2f);
            isAttack = true;
            yield return new WaitForSeconds(0.1f);
            sr.sprite = dol;
        }
        StartCoroutine(attackdelay());
    }

    // Update is called once per frame
    void Update()
    {
        stan.text="Stan konta: "+konta;

        if(!video.isPlaying)
        {
            video.Stop();
        }
        if(!you_died.isPlaying)
        {
            you_died.Stop();
        }
        if(enter.isFight)
        {
            posture_bar.sr.enabled = true;
            hp_bar.sr.enabled = true;
            if(!MORTALKOMBAT.isPlaying)
                MORTALKOMBAT.Play();
            if(!jelon.isAttack && canAttack && !isStunned)
            {
                canAttack = false;
                atak_cou = StartCoroutine(attack(Random.Range(0, 3)));
            }
            if(isAttack && jelon.isParry)
            {
                posture--;
                parowanie.Play();
                isAttack = false;
            }
            if(isAttack && jelon.isBlock && !jelon.isParry)
            {
                jelon.posture--;
                blok.Play();
                isAttack = false;
            }
            if(isAttack && !jelon.isBlock && !jelon.isParry)
            {
                jelon.hp--;
                uderzenie.Play();
                isAttack = false;
            }
            if(jelon.isAttack && canBlock && !isStunned)
            {
                sr.sprite = garda;
                jelon.posture--;
                parowanie.Play();
                jelon.isAttack = false;
            }
            if(jelon.isAttack && !canBlock)
            {
                hp--;
                uderzenie.Play();
                jelon.isAttack = false;
            }
            if(posture == 0 && !isStunned)
            {
                isStunned = true;
                sr.sprite = dol;
                isAttack = false;
                isBlock = false;
                StopCoroutine(atak_cou);
                StartCoroutine(stunned());
            }
            if(hp == 0 || jelon.hp == 0)
            {
                enter.isFight = false;
                
                if(hp == 0)
                {
                    video.Play();
                    konta+=enter.state;
                    mag.biedra();
                }
                if(jelon.hp == 0)
                {
                    you_died.Play();
                    konta-=enter.state;
                    mag.biedra();
                }
            }
            posture_bar.transform.localScale = new Vector2(10*posture, 15);
            hp_bar.transform.localScale = new Vector2(10*hp, 15);
        }
        else
        {
            posture_bar.sr.enabled = false;
            hp_bar.sr.enabled = false;
            MORTALKOMBAT.Stop();
        }
    }
}
