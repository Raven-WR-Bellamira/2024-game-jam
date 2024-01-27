using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Lives : MonoBehaviour
{
    //Player runs out of lives they die, they lose a life each time they anger a king

    public GameObject[] lives;
    private int life;
    private bool dead;


    private void Start()
    {
        life = lives.Length;
    }
    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            Debug.Log("You are Dead");
            SceneManager.LoadScene("lose");
        }
    }
    public void TakeDamage(int d)
    {
        if (life >=1)
        {
            life -= d; //1-1=0
            Destroy(lives[life].gameObject);
            if (life < 1)
            {
                dead = true;
                SceneManager.LoadScene("lose");
            }
        }
    }
}
