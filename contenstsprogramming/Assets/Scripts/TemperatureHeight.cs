using UnityEngine;

public class TemperatureHeight : MonoBehaviour
{
    // 온도 변수 (Inspector에서 조절 가능)
    public float temperature = 40.0f;
    public float maxHeight = 2.0f;  // 최대 높이

    private Transform myTransform;
    
    void Start()
    {
        myTransform = GetComponent<Transform>();
        // 온도를 높이로 변환
        
    }

    void Update()
    {
        float height = (temperature / 30.0f) * maxHeight;
        
        myTransform.localScale = new Vector3(1f, height, 1f);
        
        // Y축(세로) 크기만 변경
        transform.localScale = new Vector3(1, height, 1);
        
        // 결과 출력
        Debug.Log("온도 " + temperature + "도 → 높이 " + height);

    }
}

