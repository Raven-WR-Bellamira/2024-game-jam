using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class disappear : MonoBehaviour
{
    bool hover = false;
    bool up = false;
    bool active = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (hover == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
                active = false;
            }
        }
    }

    private void OnMouseOver()
    {
        hover = true;
        if (up == false)
        {
            transform.Translate(0, 1, 0);
            up = true;
        }
    }

    private void OnMouseExit()
    {
        hover = false;
        if (up == true)
        {
            transform.Translate(0, -1, 0);
            up = false;
        }
    }

    public bool getActive() { return active;}
}