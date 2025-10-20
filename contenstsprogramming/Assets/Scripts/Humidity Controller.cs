using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HumidityController : MonoBehaviour
{
    [Header("습도 Toggle")]
    public Toggle humidityToggle;
    
    [Header("습도 Panel")]
    public GameObject humidityPanel;
    
    [Header("습도 슬라이더")]
    public Slider humiditySlider;
    
    [Header("습도 텍스트")]
    public TextMeshProUGUI humidityText;
    
    void Start()
    {
        // 초기 상태 설정: 패널 숨김
        humidityPanel.SetActive(false);
        
        Debug.Log("습도 제어 시스템 초기화 완료!");
    }
    
    // ========== Toggle 이벤트 처리 ==========
    
    public void OnHumidityToggled(bool isOn)
    {
        // 토글 상태에 따라 패널 표시/숨김
        humidityPanel.SetActive(isOn);
        
        if (isOn)
        {
            Debug.Log("습도 정보 표시");
        }
        else
        {
            Debug.Log("습도 정보 숨김");
        }
    }
    
    // ========== Slider 이벤트 처리 ==========
    
    public void OnHumidityChanged(float value)
    {
        // 습도 값을 퍼센트로 표시 (F0 = 소수점 없음)
        humidityText.text = value.ToString("F0") + "%";
    }
}