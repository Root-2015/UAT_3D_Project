using UnityEngine;

public class Wall : MonoBehaviour
{
    public Transform trans;
    public float maxY;
    public float minY;
    public float maxZ;
    public float minZ;
    public float maxX;
    public float minX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentlocation = trans.position;
        if (currentlocation.y >= maxY){
            currentlocation.y = maxY;
            trans.position = currentlocation;
        }
        if (currentlocation.y <= minY){
            currentlocation.y = minY;
            trans.position = currentlocation;
        }
        if (currentlocation.z >= maxZ){
            currentlocation.z = maxZ;
            trans.position = currentlocation;
        }
        if (currentlocation.z <= minZ){
            currentlocation.z = minZ;
            trans.position = currentlocation;
        }
        if (currentlocation.x >= maxX){
            currentlocation.x = maxX;
            trans.position = currentlocation;
        }
        if (currentlocation.x <= minX){
            currentlocation.x = minX;
            trans.position = currentlocation;
        }
    }

    
   
}
