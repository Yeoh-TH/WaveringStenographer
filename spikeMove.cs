using UnityEngine;

public class spikeMove : MonoBehaviour
{
    public float speed = 5.0f;
    public manageGame gameManager;

    void Start()
    {
        gameManager = FindFirstObjectByType<manageGame>();
    }

    void Update()
    {
        if (transform.position.y < -6.0f)
        {
            gameManager.addScore(1);
            Destroy(this.gameObject);
        }
    }
}
