using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndCredits : MonoBehaviour
{
    public Text creditsText; // Odwo³anie do komponentu tekstowego, w którym wyœwietlane bêd¹ napisy
    public float delayBetweenCredits = 2f; // OpóŸnienie miêdzy kolejnymi napisami
    public string[] creditLines; // Tablica zawieraj¹ca poszczególne linie napisów
    private int currentIndex = 0; // Indeks aktualnie wyœwietlanej linii napisów

    private void Start()
    {
        StartCoroutine(DisplayCredits());
    }

    IEnumerator DisplayCredits()
    {
        while (currentIndex < creditLines.Length)
        {
            creditsText.text = creditLines[currentIndex];
            currentIndex++;
            yield return new WaitForSeconds(delayBetweenCredits);
        }
        EndGame();
    }

    void EndGame()
    {
        Debug.Log("Koniec gry!");
        Application.Quit();
    }
}
