using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIY : MonoBehaviour
{
    public tablet Tab;
    private bool blok;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator brok()
    {
        yield return new WaitForSeconds(0.25f);
        blok=false;
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButton(0)&&!blok)
        {
            blok=true;
            StartCoroutine(brok());
            Tab.learn();
        }
    }
}
