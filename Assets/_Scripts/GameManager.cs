using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void AddScore(int score)
    {
        _score += score;
    }

    public int GetScore()
    {
        return _score;
    }
}
