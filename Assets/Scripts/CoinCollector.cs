using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private int coinCount = 0;
    [SerializeField] private Text coinText; 

    void Start()
    {
        coinCount = 0;
        UpdateCoinUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            UpdateCoinUI();
            Destroy(other.gameObject);
        }
    }

    void UpdateCoinUI()
    {
        if (coinText != null)
            coinText.text = ": " + coinCount;
    }
}
