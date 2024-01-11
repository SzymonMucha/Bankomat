using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouseCursorPos.x, mouseCursorPos.y, -1);
    }
}
