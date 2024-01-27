using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class joke : MonoBehaviour
{
    TMP_Text m_text;
    GameObject card;
    disappear card_script;

    GameObject[] other_cards = new GameObject[3];
    joke[] other_card_scripts = new joke[3];

    private void Awake()
    {
        string object_name = gameObject.name;
        card = GameObject.FindWithTag("Card" + object_name[4]);
        card_script = card.GetComponent<disappear>();


        Debug.Log(Convert.ToInt32(object_name[4])-48 + " : "+ object_name);

        if (object_name[4] == '1')
        {
            other_cards[0] = GameObject.FindWithTag("Card2");
            other_cards[1] = GameObject.FindWithTag("Card3");
            other_cards[2] = GameObject.FindWithTag("Card4");
        }
        else if (object_name[4] == '2')
        {
            other_cards[0] = GameObject.FindWithTag("Card1");
            other_cards[1] = GameObject.FindWithTag("Card3");
            other_cards[2] = GameObject.FindWithTag("Card4");
        }
        else if (object_name[4] == '3')
        {
            other_cards[0] = GameObject.FindWithTag("Card2");
            other_cards[1] = GameObject.FindWithTag("Card1");
            other_cards[2] = GameObject.FindWithTag("Card4");
        }
        else if (object_name[4] == '4')
        {
            other_cards[0] = GameObject.FindWithTag("Card2");
            other_cards[1] = GameObject.FindWithTag("Card3");
            other_cards[2] = GameObject.FindWithTag("Card1");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        if (card != null)
        {
            Debug.Log("Card found: "+card.name);
        }
        else
        {
            Debug.Log("Error finding card");
        }


        m_text = GetComponent<TMP_Text>();

        try
        {
            while (m_text.text == other_card_scripts[0].getText() || m_text.text == other_card_scripts[1].getText() || m_text.text == other_card_scripts[2].getText())
            {
                m_text.text = card_script.getJoke();
            }
            Debug.Log(m_text.text + " -> " + name);
        }
        catch
        {
            Debug.Log("Error loading m_text -> "+name);
            m_text.text = "Error";
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = card.transform.position;

        if (!card_script.getActive())
        {
            gameObject.SetActive(false);
        }
    }

    string getText()
    {
        return m_text.text;
    }
}