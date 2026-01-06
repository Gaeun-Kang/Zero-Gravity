using UnityEngine;

public class FingerTip : MonoBehaviour
{


    public FingerManager fingerManger;
    public Transform TouchEffect;
    public Collider Collider;

    void Awake()
    {
        Collider = GetComponent<Collider>();
        TouchEffect = Collider.transform;
    }



}
