━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

📖 상황 설명

당신은 날씨 시각화 프로젝트를 시작하려고 합니다. 온도에 따라 색상이 다른 3개의 큐브를 만들어야 합니다. GameObject 생성부터 Material 적용, 색상 설정까지 전체 과정을 완성해야 합니다.
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

📦 제공된 프로젝트 상태

✅ 빈 씬 (Scene)
   • Main Camera
   • Directional Light

❌ 미완성
   • GameObject 생성 필요
   • Material 생성 필요
   • 색상 설정 필요

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

✨ 세부 요구사항

1️⃣ GameObject 생성 (0.5점)

   📦 3개의 Cube GameObject 생성
      • 이름: ColdCube, WarmCube, HotCube
      • ColdCube Position: (-3, 0, 0)
      • WarmCube Position: (0, 0, 0)
      • HotCube Position: (3, 0, 0)

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

2️⃣ Material 생성 및 적용 (0.5점)

   🎨 Material 생성 및 적용
      • ColdMat Material 생성 → ColdCube에 적용
      • WarmMat Material 생성 → WarmCube에 적용
      • HotMat Material 생성 → HotCube에 적용

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

3️⃣ Material 색상 및 속성 설정 (2점)

   🔵 ColdMat
      • Albedo: #0000FF (파란색)
      • Metallic: 0.1
      • Smoothness: 0.8

   🟢 WarmMat
      • Albedo: #00FF00 (초록색)
      • Metallic: 0.3
      • Smoothness: 0.6

   🔴 HotMat
      • Albedo: #FF0000 (빨간색)
      • Metallic: 0.5
      • Smoothness: 0.4

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

4️⃣ Prefab 생성 및 인스턴스 배치 (1점)

   📦 ColdCube Prefab 생성
      • ColdCube를 Prefab으로 저장 (이름: ColdCubePrefab)
      • Prefabs 폴더에 저장

   🔄 Prefab 인스턴스 추가 생성
      • ColdCubePrefab에서 2개의 인스턴스 생성
      • 첫 번째 인스턴스 Position: (-5, 0, 0)
      • 두 번째 인스턴스 Position: (-4, 0, 0)

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

5️⃣ 채점 기준

Play 모드에서 다음과 같이 표시되어야 합니다:

   ✅ GameObject 3개 생성 및 배치
      • ColdCube at (-3, 0, 0)
      • WarmCube at (0, 0, 0)
      • HotCube at (3, 0, 0)

   ✅ Material 적용 및 색상 설정
      • ColdCube: 파란색 #0000FF, Metallic 0.1, Smoothness 0.8
      • WarmCube: 초록색 #00FF00, Metallic 0.3, Smoothness 0.6
      • HotCube: 빨간색 #FF0000, Metallic 0.5, Smoothness 0.4

   ✅ Prefab 시스템
      • ColdCubePrefab이 Prefabs 폴더에 존재
      • Prefab 인스턴스 2개가 (-5, 0, 0), (-4, 0, 0)에 배치
      • 총 5개의 파란색 큐브 (원본 1개 + Prefab 인스턴스 2개 + 기타 2개)

⚠️ 주의사항:
• GameObject 이름 정확히 일치: ColdCube, WarmCube, HotCube
• Material 이름 정확히 일치: ColdMat, WarmMat, HotMat
• Prefab 이름 정확히 일치: ColdCubePrefab
• Position, Metallic, Smoothness 값이 정확해야 함
• Prefab은 Prefabs 폴더에 저장되어야 함

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
