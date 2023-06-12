using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    public Image gameOverImage;
    public string nextSceneName;
   

    public void ShowGameOver(bool isWin)
    {
        if (isWin)
        {
            gameOverImage.sprite = Resources.Load<Sprite>("SciezkaDoObrazuWygranej"); // Zmieni� "SciezkaDoObrazuWygranej" na w�a�ciw� �cie�k� do obrazu wygranej
        }
        else
        {
            gameOverImage.sprite = Resources.Load<Sprite>("Assets/ZGON.png"); // Zmieni� "SciezkaDoObrazuPrzegranej" na w�a�ciw� �cie�k� do obrazu przegranej
        }

        gameOverImage.gameObject.SetActive(true);
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}