using UnityEngine;
using UnityEngine.UI;

namespace Assets._Code.Scripts.GameManager
{
    public class GameManagerController : MonoBehaviour
    {
        public Text enemiesPassCount;
        public Text enemyKillCount;
        public Text coinsCount;

        private int _enemyPassCount = 0;
        private int _enemyKillCount = 0;
        private int _coinsCount = 0;

        public void AddEnemyKillCount()
        {
            _enemyKillCount++;
            enemyKillCount.text = _enemyKillCount.ToString();
        }

        public void AddEnemyPassCount()
        {
            _enemyPassCount++;
            enemiesPassCount.text = _enemyPassCount.ToString();
        }

        public void AddCoinCount()
        {
            _coinsCount += 2;
            coinsCount.text = _coinsCount.ToString();
        }
    }
}
