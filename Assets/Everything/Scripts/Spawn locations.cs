using UnityEngine;

public class Spawnlocations : MonoBehaviour
{
    public GameObject prefabToCopy;
    public GameManager theMan;
    public float firstSpawn;
    public float SecondSpawn;
    public float ThirdSpawn;
    private bool spawn1;
    private bool spawn2;
    private bool spawn3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (firstSpawn >= theMan.timeRemaining){
            if (spawn1 != true){
            Spawn();
            spawn1 = true;}
        }
        if (SecondSpawn >= theMan.timeRemaining){
            if (spawn2 != true){
            Spawn();
            spawn2 = true;}
        }
        if (ThirdSpawn >= theMan.timeRemaining){
            if (spawn3 != true){
            Spawn();
            spawn3 = true;}
        }
    }

    public void Spawn(){
    Instantiate(prefabToCopy);
    }

}
