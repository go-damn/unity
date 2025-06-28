using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;

public class earth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float Rotatevelocity = 10;
    [SerializeField] GameObject star;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(star.transform.position, Vector3.up, 2*Time.deltaTime);
    }
}
