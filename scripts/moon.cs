using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class moon : MonoBehaviour
{
    [SerializeField] GameObject planet;
    public float Rotatevelocity = 30;
    Vector3 dir;
    float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distance = Vector3.Distance(this.transform.position, planet.transform.position);
        dir = (this.transform.position - planet.transform.position) .normalized;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = planet.transform.position + dir * distance;
        transform.RotateAround(planet.transform.position, Vector3.up, 20 * Time.deltaTime);
        dir = (this.transform.position - planet.transform.position) .normalized;
    }
}
