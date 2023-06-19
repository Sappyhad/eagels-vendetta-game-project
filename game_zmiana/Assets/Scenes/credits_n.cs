using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndCredits : MonoBehaviour
{
    public Text creditsText; // Odwo�anie do komponentu tekstowego, w kt�rym wy�wietlane b�d� napisy
    public float delayBetweenCredits = 2f; // Op�nienie mi�dzy kolejnymi napisami
    public string[] creditLines; // Tablica zawieraj�ca poszczeg�lne linie napis�w
    private int currentIndex = 0; // Indeks aktualnie wy�wietlanej linii napis�w

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
