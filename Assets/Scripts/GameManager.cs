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
            Debug.Log("�� ��������� �� ����� ������� ������ �������.");
            StopGame();
        }

        if (_playerWallet.CheckCoinCount() == true)
        {
            Debug.Log("�� ������� ��� ������ � ��������!");
            StopGame();
        }
    }

    private void StopGame()
    {
        _playerRigidbody.isKinematic = true;
        Debug.Log("������� R ��� ��������");
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
    }
}