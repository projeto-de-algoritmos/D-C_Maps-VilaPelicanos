using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingUI : MonoBehaviour
{
    public float floatSpeed = 1f;  // Velocidade do movimento de flutua��o
    public float floatHeight = 10f;  // Altura m�xima de flutua��o
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Movimento senoidal para simular flutua��o
        float newY = Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, newY);
    }
}
