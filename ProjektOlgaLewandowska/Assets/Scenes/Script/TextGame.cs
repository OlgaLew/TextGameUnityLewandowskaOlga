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
        Debug.Log("Witaj w mojej grze");
        Debug.Log("Wymy�l  w g�owie liczb� od 1 do 100");
        Debug.Log("Czy twoja liczba jest wi�ksza od 500?");
        Debug.Log("Nacisnij g�rn� stra�k� je�li twoja liczba jest wi�ksza \n" +
                 "Naci�nij doln� strza�k� je�li jest mniejsza \n");
        Debug.Log("Naci�nij enter je�li jest r�wna czyli program zgadnie twoj� liczb� ");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("g�ra");
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest wieksza od ?");

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("d�");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("enter");
        }
    }
}
