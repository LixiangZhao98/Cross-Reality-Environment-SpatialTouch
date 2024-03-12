using UnityEngine;

public class FloatUpDown : MonoBehaviour
{
    public float amplitude = 0.5f;

    public float frequency = 1f;
    public Transform model;

    private Vector3 startPos;

    void Start()
    {
        startPos = model.transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * frequency) * amplitude;

        model.transform.position = startPos + new Vector3(0, newY, 0);
    }
}