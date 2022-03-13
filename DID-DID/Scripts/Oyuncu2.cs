using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu2 : MonoBehaviour
{
    // config params
    [SerializeField] float minY = 1f;
    [SerializeField] float maxY = 11f;
    [SerializeField] float screenHeightInUnits = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float oyuncu2YPos = transform.position.y;
        Vector2 oyuncu2Pos = new Vector2(transform.position.x, transform.position.y);

        if (Input.GetKey("up"))
        {
            oyuncu2YPos = oyuncu2YPos + 0.2f;
        }

        if (Input.GetKey("down"))
        {
            oyuncu2YPos = oyuncu2YPos - 0.2f;
        }

        oyuncu2Pos.y = Mathf.Clamp(oyuncu2YPos, minY, maxY);
        transform.position = oyuncu2Pos;
    }
}
