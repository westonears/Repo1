using UnityEngine;

public class TemperatureColor : MonoBehaviour
{
    // 온도 변수
    public float temperature = 25.0f;

    public Color coldColor = Color.blue;
    public Color normalColor = Color.green;
    public Color hotColor = Color.red;

    private Renderer myRenderer;
    
    void Start()
    {
        // Renderer 컴포넌트 가져오기
        myRenderer = GetComponent<Renderer>();
    }
    void Update()
    {

        if (temperature < 15.0f)
        {
            myRenderer.material.color = Color.blue;
            Debug.Log(temperature + "도: 차가워요! (파란색)");
        }
        else if (temperature < 30.0f)
        {
            myRenderer.material.color = Color.green;
            Debug.Log(temperature + "도: 적당해요! (녹색)");
        }
        else
        {
            myRenderer.material.color = Color.red;
            Debug.Log(temperature + "도: 뜨거워요! (빨간색)");
        }
    }
}
