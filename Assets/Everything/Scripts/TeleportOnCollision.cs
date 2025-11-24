using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;

    void OnTriggerEnter(Collider other)
    {
        float randomX = Random.Range(minX, maxX);
	    float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);
	    transform.position = new Vector3(randomX, randomY, randomZ);
    }
}

