using UnityEngine;

public class WeatherData : MonoBehaviour
{
    public float temp = 25.5f;
    public float humidity = 60f;
    public float realtemp = 23.5f;

    void Start()
    {
        Debug.Log("서울의 온도: " + temp);
        Debug.Log("습도: " + humidity);
        Debug.Log("체감온도: " + realtemp);
    }
}
