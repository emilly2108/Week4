using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }
    void start()
    {
        Debug.Log("사냥장비를 챙겼습니다.");
    }

    private void FixedUpdate()
    {
        Debug.Log("이동~");
    }
    private void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }
    private void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    private void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    void OnDestroy()
    {
        Debug.Log("플레이어의 데이터를 해체했습니다.");
    }
}
