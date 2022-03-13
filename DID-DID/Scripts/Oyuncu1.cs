using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu1 : MonoBehaviour
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
        float mousePosInUnits = Input.mousePosition.y / Screen.height * screenHeightInUnits;
        Vector2 oyuncu1Pos = new Vector2(transform.position.x, transform.position.y);
        oyuncu1Pos.y = Mathf.Clamp(mousePosInUnits, minY, maxY);
        transform.position = oyuncu1Pos;
    }
}
