using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (LogicScript.currentPipeSpeed * Time.deltaTime);
        
        if (transform.position.x < deadZone)
        {
            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
