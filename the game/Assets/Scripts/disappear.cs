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

    string[] jokes = { "joke0:trait 1", "joke1:trait 1", "joke2: trait 2", "joke3:trait 3" };
    string[] traits = { "0", "1", "2", "3" };
    int joke_index;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(getTrait()+" : "+getJoke());
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

    public string getJoke()
    {
        joke_index = Random.Range(0, jokes.Length - 1);
        string joke_string = "";
        int i = 0;
        while (jokes[joke_index][i] != ':')
        {
            joke_string += jokes[joke_index][i];
            i++;
        }
        return joke_string;
    }

    public string getTrait()
    {
        string trait = "";
        string flipped_trait = "";
        int i = jokes[joke_index].Length-1;
        while (jokes[joke_index][i] != ':')
        {
            flipped_trait += jokes[joke_index][i];
            i--;
        }
        for(int j = flipped_trait.Length-1; j >= 0; j--)
        {
            trait += flipped_trait[j];
        }
        return trait;
    }
}