using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    [SerializeField] private Text healthText;

    private int currentHealth;

     public void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        currentHealth--;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    public void UpdateHealthUI()
    {
        if (healthText != null)
            healthText.text = ": " + currentHealth;
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0;
        SceneManager.LoadScene("GameOver");
    }
}

