using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    /*void Update()
   {
       if (Input.anyKeyDown)
           Debug.Log("�÷��̾ �ƹ�Ű�� �������ϴ�.");*/

    /*if (Input.GetKeyDown(KeyCode.Return))
        Debug.Log("�������� �����Ͽ����ϴ�.");

    if (Input.GetKeyDown(KeyCode.LeftArrow))
        Debug.Log("�������� �̵� ��");

    if (Input.GetKeyUp(KeyCode.RightArrow))
        Debug.Log("������ �̵��� ���߾����ϴ�.");*/

    /*if (Input.GetMouseButtonDown(0))
        Debug.Log("�̻��� �߻�!");

    if (Input.GetMouseButton(0))
        Debug.Log("�̻��� ������ ��...");

    if (Input.GetMouseButtonUp(0))
        Debug.Log("���� �̻��� �߻�!!");*/

    /* if (Input.GetButtonDown("Jump"))
         Debug.Log("����!");

     if (Input.GetButton("Jump"))
         Debug.Log("���� ������ ��...");

     if (Input.GetButtonUp("Jump"))
         Debug.Log("���� ����!!");*/

    /*if (Input.GetButton("Horizontal"))
    {
        Debug.Log("Ⱦ �̵� �� ..." + Input.GetAxisRaw("Horizontal"));
    }
    if (Input.GetButton("Vertical"))
    {
        Debug.Log("�� �̵� �� ..." + Input.GetAxisRaw("Vertical"));
    }
}
    */
    void Start()
    {
       /* transform.Translate(Vector3);

        int number = 4; //��Į�� ��
        Vector3 vec = new Vector3(0, 0, 0);//���� ��
        transform.Translate(vec);*/
    }
     void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw(" Horizontal"), Input.GetAxisRaw(" Vertical"), 0);
        transform.Translate(vec);
    }
}
