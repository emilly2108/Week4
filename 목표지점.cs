using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        //1.MoveTow0
        //transform.position = Vector3.MoveTowards(transform.position , target, 1f);

        //2.smoothDamp
        /* Vector3 velo = Vector3.zero;
         transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);*/

        //3.Lerp(��������)
        // transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        //4.Slerp(���� ���� ����)
        transform.position = Vector3.Slerp(transform.position, target, 0.1f);
    }
}
