using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    //Minimalna i maksymalna wartoœæ
    int min = 1;
    int max = 1000;
    int guess = 500;
    string choice;

    void GuessScope()
    {
        Debug.Log("Podaj z jakiego zakresu ma zgadywaæ komputer");
        Debug.Log("Jeœli od 1 do 50 to naciœnij klawisz 1");
        Debug.Log("Jeœli od 1 do 1000 to naciœnij klawisz 2");
        Debug.Log("Jeœli od 1 do 10000 to naciœnij klawisz 3");
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
        Debug.Log("Wymyœl  w g³owie liczbê od  " + min + " do  " + max);
        Debug.Log("Czy twoja liczba jest wiêksza od " + guess + "?");
        Debug.Log("Nacisnij górn¹ strza³kê jeœli twoja liczba jest wiêksza \n");
        Debug.Log("Naciœnij doln¹ strza³kê jeœli jest mniejsza \n");
        Debug.Log("Naciœnij enter jeœli jest równa czyli program zgadnie twoj¹ liczbê ");
        max++;//zwieksz wartoœæ o 1
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
