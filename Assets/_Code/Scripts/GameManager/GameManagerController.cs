using UnityEngine;
using UnityEngine.UI;

public class GameManagerController : MonoBehaviour
{
    public Text enemiesPassCountText;
    public Text enemiesDeathsCountText;
    public Text coinsCountText;

    private int enemiesPassCount = 0;
    private int enemiesDeathsCount = 0;
    private int coinsCount = 0;

    public void AddEnemyPassCount()
    {
        enemiesPassCount++;
        enemiesPassCountText.text = enemiesPassCount.ToString();
    }

    public void AddEnemyDeathCount()
    {
        enemiesDeathsCount++;
        enemiesDeathsCountText.text = enemiesDeathsCount.ToString();
    }

    public void AddCoinCount()
    {
        coinsCount++;
        coinsCountText.text = coinsCount.ToString();
    }
}
