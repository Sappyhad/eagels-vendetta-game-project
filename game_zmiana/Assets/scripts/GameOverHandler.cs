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
            gameOverImage.sprite = Resources.Load<Sprite>("SciezkaDoObrazuWygranej"); // Zmieniæ "SciezkaDoObrazuWygranej" na w³aœciw¹ œcie¿kê do obrazu wygranej
        }
        else
        {
            gameOverImage.sprite = Resources.Load<Sprite>("Assets/ZGON.png"); // Zmieniæ "SciezkaDoObrazuPrzegranej" na w³aœciw¹ œcie¿kê do obrazu przegranej
        }

        gameOverImage.gameObject.SetActive(true);
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}