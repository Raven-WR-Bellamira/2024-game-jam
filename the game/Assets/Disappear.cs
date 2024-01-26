using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    bool hover = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && hover == true)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnMouseOver()
    {
        hover = true;
    }

    private void OnMouseExit()
    {
        hover = false;
    }
}
