using UnityEngine;

public class ThermometerController : MonoBehaviour
{
    [Header("온도 설정")]
    public float temperature = 25.0f;     // 온도
    public float maxHeight = 3.0f;        // 최대 높이

    private Renderer objectRenderer;      // 온도계의 Renderer
    public Renderer groundRenderer;       // ✅ Ground의 Renderer (Inspector에서 할당)

    void Start()
    {
        // Renderer 컴포넌트 가져오기
        objectRenderer = GetComponent<Renderer>();
        
        if (objectRenderer == null)
        {
            Debug.LogError("이 GameObject에는 Renderer가 없습니다!");
        }

        if (groundRenderer == null)
        {
            Debug.LogWarning("Ground Renderer가 지정되지 않았습니다. 색상 제어 불가!");
        }
        
        Debug.Log("온도계 시작! 초기 온도: " + temperature + "도");
    }
    
    void Update()
{
    // 1️⃣ 높이 제어 (온도에 비례)
    float height = temperature / 50.0f * maxHeight;
    if (height < 0.1f) height = 0.1f;
    transform.localScale = new Vector3(1, height, 1);

    // ✅ 중심에서 위로 보정 (Ground 위로 올라오게)
    // 예: 큐브 pivot이 중심이면, 절반만큼 위로 올리면 됨
    transform.position = new Vector3(
        transform.position.x,
        height / 2.0f,   // 중심이 아니라 맨 아래가 Ground에 닿도록
        transform.position.z
    );

    // 2️⃣ 온도계 색상 제어
    if (objectRenderer != null)
    {
        if (temperature < 15.0f)
            objectRenderer.material.color = Color.blue;
        else if (temperature < 30.0f)
            objectRenderer.material.color = Color.green;
        else
            objectRenderer.material.color = Color.red;
    }

    // 3️⃣ Ground 색상 제어
    if (groundRenderer != null)
    {
        if (temperature < 15.0f)
            groundRenderer.material.color = Color.white;
        else if (temperature < 30.0f)
            groundRenderer.material.color = new Color(0.59f, 0.29f, 0.0f); // 갈색
        else
            groundRenderer.material.color = new Color(1.0f, 0.5f, 0.0f);   // 주황색
    }
}

}
