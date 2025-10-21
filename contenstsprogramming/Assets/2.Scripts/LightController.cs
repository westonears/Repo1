using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    [Header("오브젝트 연결")]
    public Renderer lightBulb;       // 전구 Mesh Renderer
    public Text statusText;          // 밝기 상태 표시 텍스트
    public GameObject infoPanel;     // 정보 패널
    public Text infoText;            // 패널 안의 텍스트

    private bool isBright = false;   // 현재 밝기 상태 저장 (false = 어두움)

    void Start()
    {
        // ✅ 초기 상태 설정
        isBright = false;
        if (lightBulb != null)
            lightBulb.material.color = Color.gray;

        if (statusText != null)
            statusText.text = "밝기: 어두움";

        if (infoPanel != null)
            infoPanel.SetActive(false);
    }

    // ✅ "밝게" 버튼 클릭 시
    public void SetBright()
    {
        isBright = true;

        if (lightBulb != null)
            lightBulb.material.color = Color.white;

        if (statusText != null)
            statusText.text = "밝기: 밝음";

        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
            if (infoText != null)
                infoText.text = "현재 조명이 켜져 있습니다";
        }
    }

    // ✅ "어둡게" 버튼 클릭 시
    public void SetDark()
    {
        isBright = false;

        if (lightBulb != null)
            lightBulb.material.color = Color.gray;

        if (statusText != null)
            statusText.text = "밝기: 어두움";

        if (infoPanel != null)
            infoPanel.SetActive(false);
    }
}
