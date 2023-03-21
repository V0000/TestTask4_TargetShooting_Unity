using TMPro;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] TextMeshPro pointsText;
    [SerializeField] int pointsToWin = 3;
    [SerializeField] GameObject endGameScreen;

    int points;
    void Start()
    {
        endGameScreen.SetActive(false);
    }

        
    void Update()
    {
        points = int.Parse(pointsText.text);
        if (points >= pointsToWin)
        {
            endGameScreen.SetActive(true);
        }
    }
}
