using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paski : MonoBehaviour
{
    public int rodzaj; //0 - żyćko bankomatu; 1 - postura bankomatu; 2 - żyćko jelenia; 3 - pastura jelenia
    private Transform t;
    public int size = 0;
    public Image sr;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        sr = GetComponent<Image>();
    }

    /*void change_x(int s)
    {
        t.localScale = new Vector2(10*s, 15);
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
