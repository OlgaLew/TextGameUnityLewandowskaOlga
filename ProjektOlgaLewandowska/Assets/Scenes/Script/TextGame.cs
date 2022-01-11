using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    //Minimalna i maksymalna warto��
    int min = 1;
    int max = 1000;
    int guess = 500; 

    // Start is called before the first frame update
    void Start()
    {
        guess = (min + max) / 2;
        Debug.Log("Witaj w mojej grze");
        Debug.Log("Wymy�l  w g�owie liczb� od  "+min+" do  "+max);
        Debug.Log("Czy twoja liczba jest wi�ksza od " +guess);
        Debug.Log("Nacisnij g�rn� stra�k� je�li twoja liczba jest wi�ksza \n" +
                 "Naci�nij doln� strza�k� je�li jest mniejsza \n");
        Debug.Log("Naci�nij enter je�li jest r�wna czyli program zgadnie twoj� liczb� ");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest wieksza od " +guess );
           

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest wieksza od " +guess);
           
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            Debug.Log("Zgadlem twoja liczbe! Jestem superkomputerem z chin!");
        }
    }
}
