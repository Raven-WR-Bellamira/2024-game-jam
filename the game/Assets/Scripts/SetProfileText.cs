using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SetProfileText : MonoBehaviour
{

    int KingNumber = 1;
    public Text KingName;
    public Text Likes;
    string Like1;
    string Like2;
    string Like3;

    // Start is called before the first frame update
    void Start()
    {
        if (KingNumber == 1)
        {
            
            KingName.text = ("King of Hearts");
            KingName.color = Color.red;

        }
        else if (KingNumber == 2)
        {
            KingName.text = ("King of Diamonds");
            KingName.color = Color.red;
        }
        else if (KingNumber == 3)
        {
            KingName.text = ("King of Spades");
            KingName.color = Color.black;
        }
        else
        {
            KingName.text = ("King of Clubs");
            KingName.color = Color.black;

        }

        if (Random.Range(1,3) == 1)
        {
            Like1 = "sports";
            Like2 = "hunting";
            Like3 = "Politics";
        }
        else
        {
            Like1 = "bull";
            Like2 = "null";
            Like3 = "pull";
        }

        Likes.text = (Like1 + Like2 + Like3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
