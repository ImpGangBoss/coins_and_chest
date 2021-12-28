using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Transform spawnPosition;
    public Text balanceCounter;

    private void Start()
    {
        UpdateBalance();
    }

    public void SpawnCoin()
    {
        GameObject coin = CoinPool.SharedInstance.GetPooledCoin();
        if (coin != null)
        {
            coin.transform.position = spawnPosition.transform.position;
            coin.transform.rotation = spawnPosition.transform.rotation;
            coin.SetActive(true);

            GameData.DecreaseBalanceByValue(1);
            UpdateBalance();
        }
    }

    public void UpdateBalance()
    {
        balanceCounter.text = GameData.GetBalance().ToString();
    }
}
