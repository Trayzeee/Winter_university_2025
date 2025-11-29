using UnityEngine;

public class BricksManager : MonoBehaviour
{
    [Header("Параметры пирамиды")]
    public int rows = 5;                 
    public float brickWidth = 4f;
    public float brickHeight = 2f;
    public float brickDepth = 2f;

    [Header("Позиция пирамиды относительно этого объекта")]
    public Vector3 offset = new Vector3(0f, 1f, 10f);

    [Header("Визуал")]
    public Color brickColor = Color.gray;

    [Header("Разброс")]
    public float posJitterX = 0.25f;    
    public float posJitterY = 0.1f;      
    public float posJitterZ = 0.2f;      
    public float rotJitterX = 3f;     
    public float rotJitterY = 12f;      
    public float rotJitterZ = 3f;       

    void Start()
    {
        SpawnPyramid();
    }

    void SpawnPyramid()
    {
        var basePos = transform.position + offset;

        for (int y = 0; y < rows; y++)
        {
            int bricksInRow = rows - y;
            float rowWidth = bricksInRow * brickWidth;
            float rowStartX = -rowWidth / 2f + brickWidth / 2f;

            for (int x = 0; x < bricksInRow; x++)
            {
                Vector3 pos = basePos +
                              new Vector3(rowStartX + x * brickWidth,
                                          y * brickHeight + brickHeight / 2f,
                                          0f);

                pos.x += Random.Range(-posJitterX, posJitterX);
                pos.y += Random.Range(-posJitterY, posJitterY);
                pos.z += Random.Range(-posJitterZ, posJitterZ);

                GameObject brick = GameObject.CreatePrimitive(PrimitiveType.Cube);
                brick.name = $"Brick_{y}_{x}";
                brick.transform.position = pos;
                brick.transform.localScale = new Vector3(brickWidth, brickHeight, brickDepth);

                float rx = Random.Range(-rotJitterX, rotJitterX);
                float ry = Random.Range(-rotJitterY, rotJitterY);
                float rz = Random.Range(-rotJitterZ, rotJitterZ);
                brick.transform.rotation = Quaternion.Euler(rx, ry, rz);

                var renderer = brick.GetComponent<Renderer>();
                renderer.material = new Material(Shader.Find("Standard"));
                renderer.material.color = brickColor;
            }
        }
    }
}
