using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }
    void start()
    {
        Debug.Log("������ ì����ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }
    private void Update()
    {
        Debug.Log("���� ���!!");
    }
    private void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    private void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }
    void OnDestroy()
    {
        Debug.Log("�÷��̾��� �����͸� ��ü�߽��ϴ�.");
    }
}
