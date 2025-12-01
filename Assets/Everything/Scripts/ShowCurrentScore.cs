using UnityEngine;
using TMPro;
public class ShowCurrentScore : MonoBehaviour
{
    public TMP_Text text;
    public Bestscore high;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        high = FindObjectOfType<Bestscore>();
        text.text = "Last score: " + high.currentScore;
    }
}