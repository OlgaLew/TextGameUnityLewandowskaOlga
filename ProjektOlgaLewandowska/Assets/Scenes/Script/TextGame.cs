using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    //Minimalna i maksymalna warto��
    int min = 1;
    int max = 1000;
    int guess = 500;
    string choice;

    void GuessScope()
    {
        Debug.Log("Podaj z jakiego zakresu ma zgadywa� komputer");
        Debug.Log("Je�li od 1 do 50 to naci�nij klawisz 1");
        Debug.Log("Je�li od 1 do 1000 to naci�nij klawisz 2");
        Debug.Log("Je�li od 1 do 10000 to naci�nij klawisz 3");
        if (choice == "1")
        {

        }
        if (true)
        {

        }
        if (true)
        {

        }

        switch (choice)
            {
            case "1":
                min = 1;
                max = 50;
                break;
            case "2":
                min = 1;
                max = 1000;
                break;
            case "3":
                min = 1;
                max = 10000;
                break;

        }

    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest wieksza od " + guess + "?");
    }

    void StartGame()
    {
        guess = (min + max) / 2;
        Debug.Log("Witaj w mojej grze");
        Debug.Log("Wymy�l  w g�owie liczb� od  " + min + " do  " + max);
        Debug.Log("Czy twoja liczba jest wi�ksza od " + guess + "?");
        Debug.Log("Nacisnij g�rn� strza�k� je�li twoja liczba jest wi�ksza \n");
        Debug.Log("Naci�nij doln� strza�k� je�li jest mniejsza \n");
        Debug.Log("Naci�nij enter je�li jest r�wna czyli program zgadnie twoj� liczb� ");
        max++;//zwieksz warto�� o 1
    }

    // Start is called before the first frame update
    void Start()
    {

        StartGame();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            NextGuess();
           

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            NextGuess();

        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            Debug.Log("Zgadlem twoja liczbe! Jestem superkomputerem z chin!");
        }
    }
}
