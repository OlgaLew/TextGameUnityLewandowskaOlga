using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    //Minimalna i maksymalna wartoœæ
    int min = 1;
    int max = 1000;
    int guess = 500; 

    // Start is called before the first frame update
    void Start()
    {
        guess = (min + max) / 2;
        Debug.Log("Witaj w mojej grze");
        Debug.Log("Wymyœl  w g³owie liczbê od  "+min+" do  "+max);
        Debug.Log("Czy twoja liczba jest wiêksza od " +guess);
        Debug.Log("Nacisnij górn¹ stra³kê jeœli twoja liczba jest wiêksza \n" +
                 "Naciœnij doln¹ strza³kê jeœli jest mniejsza \n");
        Debug.Log("Naciœnij enter jeœli jest równa czyli program zgadnie twoj¹ liczbê ");

        
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
