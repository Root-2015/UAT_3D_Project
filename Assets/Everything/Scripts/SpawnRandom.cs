using UnityEngine;

public class Spawnrandom : MonoBehaviour
{
    public Spawnlocations pre;
    public float number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        number = Random.Range(0, 10);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (number > 0){
            pre.Spawn();
            number = (number-1);
        }
    }

}
