using UnityEngine;

public class FloatUpDown : MonoBehaviour
{
    public float amplitude = 0.5f;

    public float frequency = 1f;
    public Transform model;
    public float rotationSpeed = 0f;

    private Vector3 startPos;private float time;

    void Start()
    {
        startPos = model.transform.position;
    }

    void Update()
    {
       
            float newY = Mathf.Sin(time * frequency) * amplitude;

            model.transform.position = startPos + new Vector3(0, newY, 0); time += Time.deltaTime;
       
        //if (Input.GetKey(KeyCode.Z))
        //{
        //    model.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        //}
     
    }
}