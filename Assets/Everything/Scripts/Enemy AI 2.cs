using UnityEngine;

public class EnemyAI2 : MonoBehaviour
{
    public Transform target;
    public Transform trans;
    public Hero hero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hero == true)
        trans.LookAt(target);
    }
}
