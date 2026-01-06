using System.Collections.Generic;
using UnityEngine;

public class FingerManager : MonoBehaviour
{
    //left, right 분리 
    //collider 작동시 TipEffect 생성할것 

    private Rigidbody rb;
    public ParticleSystem TipEffectPrefab;
    public GameObject LeftHand;
    public GameObject RightHand;


    public List<Collider> LeftFingerTips;
    public List<Collider> RightFingerTips;

    public enum HandType { Left, Right}


    void Awake()
    {
        if(rb == null)rb = GetComponent<Rigidbody>();

        FingerTipCollider(LeftHand,LeftFingerTips,HandType.Left);
        FingerTipCollider(RightHand,RightFingerTips, HandType.Right);

    }

    void FingerTipCollider(GameObject Hand, List<Collider> FingerTips, HandType handtype )
    {
        Collider[] colliders = Hand.GetComponentsInChildren<Collider>();
        for (int i = 0; i < colliders.Length; i++)
        {
            FingerTips.Add(colliders[i]);
        }
    }


    void OnFingerEnter(HandType handtype, FingerTip finger,bool isTouching,Collider other)
    {
        if (other.CompareTag("Target"))
        {

        }
    }

    void Update()
    {
        
    }
}
