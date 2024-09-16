using System.Collections.Generic;
using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private List<Coin> coinList = new List<Coin>();
    [SerializeField] private Coin[] _coins;

    private bool _collectAllCoin = false;

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.gameObject.GetComponent<Coin>();

        if (coin != null)
        {
            coinList.Add(coin);
            coin.gameObject.SetActive(false);
        }
    }

    public bool CheckCoinCount()
    {
        if(_coins.Length == coinList.Count)
        {
            _collectAllCoin = true;
        }
        return _collectAllCoin;
    }
}