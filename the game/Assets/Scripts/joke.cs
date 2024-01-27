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

    private void Awake()
    {
        string object_name = gameObject.name;
        card = GameObject.FindWithTag("Card" + object_name[4]);
        card_script = card.GetComponent<disappear>();
    }

    // Start is called before the first frame update
    void Start()
    {

        if (card != null)
        {
            Debug.Log("Card found");
        }
        else
        {
            Debug.Log("Error finding card");
        }


        m_text = GetComponent<TMP_Text>();
        m_text.text = "hi";

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
}
