using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnit = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnit);
        float xValue = Input.mousePosition.x / Screen.width * screenWidthInUnit;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(xValue, minX, maxX);
        transform.position = paddlePos;
    }
}
