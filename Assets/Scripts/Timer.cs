using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeForGame;

    private float _stepWriteTime = 1;

    public bool TimeOver { get; private set; } = false;

    private void Update()
    {
        if (TimeOver == false)
        {
            _stepWriteTime -= Time.deltaTime;
            _timeForGame -= Time.deltaTime;
            if(_stepWriteTime <= 0)
            {
                _stepWriteTime = 1;
                Debug.Log((int)_timeForGame);
                if (_timeForGame <= 0)
                {
                    TimeOver = true;
                    Debug.Log("Время вышло");
                }
            } 
        } 
    }
}