using UnityEngine;

public class ArrangeDoorsInCircle : MonoBehaviour
{
    public GameObject[] prefabs; // Array of doors to arrange
    public float radius = 5f;    // Radius of the circle
    public int numberOfDoors = 3; // Number of doors to arrange

    void Start()
    {
        ArrangeDoors();
    }

    void ArrangeDoors()
    {
        float angleIncrement = 360f / numberOfDoors;
        for (int i = 0; i < numberOfDoors; i++)
        {
            float angle = i * angleIncrement;
            float x = radius * Mathf.Cos(Mathf.Deg2Rad * angle);
            float z = radius * Mathf.Sin(Mathf.Deg2Rad * angle);
            Vector3 position = new Vector3(x, 0f, z);
            Instantiate(prefabs[i % prefabs.Length], position, Quaternion.identity);
        }
    }
}
