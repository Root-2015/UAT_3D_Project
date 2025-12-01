using UnityEngine;

public class hIghscoreChange : MonoBehaviour
{
    private Bestscore high;
    public GameManager manager;
    public void MainScore()
    {
        high = FindObjectOfType<Bestscore>();
        high.currentScore = manager.realScore;
        if (high.currentScore >= high.bestScore){
        high.bestScore = high.currentScore;
        }
    }
}
