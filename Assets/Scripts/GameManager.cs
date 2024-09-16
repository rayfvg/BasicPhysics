using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private PlayerWallet _playerWallet;

    private void Update()
    {
        if (_timer.TimeOver == true)
        {
            Debug.Log("Вы проиграли не успев собрать монеты вовремя.");
            StopGame();
        }

        if (_playerWallet.CheckCoinCount() == true)
        {
            Debug.Log("Вы собрали все монеты и победили!");
            StopGame();
        }
    }

    private void StopGame()
    {
        _playerRigidbody.isKinematic = true;
        Debug.Log("Нажмите R для рестарта");
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
    }
}