using UnityEngine;

public class EnemyAI1 : MonoBehaviour
{
    public Transform target;
    public Transform trans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = GetComponent<Transform>();
        trans.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
