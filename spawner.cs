using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject spikes;
    public float widthOffset = 25.0f;

    void Start() { 
   
        InvokeRepeating("createSpikes", 2.0f, 1.0f);
    }

    void createSpikes()
    {
        float furthestPoint = transform.position.x - widthOffset;
        float closestPoint = transform.position.x + widthOffset;

        Instantiate(spikes, new Vector3(Random.Range(closestPoint, furthestPoint), transform.position.y), transform.rotation);
    }

}
