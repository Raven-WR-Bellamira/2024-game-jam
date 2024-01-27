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

    // Start is called before the first frame update
    void Start()
    {
        if (KingNumber == 1)
        {
            
            KingName.text = ("Red King of Hearts");
            KingName.color = Color.red;
            Likes.text = ("Likes: " + "Music " + "Cats " + "Jewelry " + "Agriculture ");

        }
        else if (KingNumber == 2)
        {
            KingName.text = ("Red King of Diamonds");
            KingName.color = Color.red;
            Likes.text = ("Likes: "+"Fishing " 
                + "Dogs " 
                + "Religion " 
                + "Royal Family ");
        }
        else if (KingNumber == 3)
        {
            KingName.text = (" Black King of Spades");
            KingName.color = Color.black;
            Likes.text = ("Likes: " + "Eating " 
                + "Weapons of War " 
                + "Hunting " 
                + "War ");
        }
        else
        {
            KingName.text = ("Black King of Clubs");
            KingName.color = Color.black;
            Likes.text = ("Likes: " + "Money "
                + "Wine " 
                + "Sightseeing " 
                + "Higher Class ");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
