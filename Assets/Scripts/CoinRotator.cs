using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, 1 * _speed * Time.deltaTime, 0);
    }
}