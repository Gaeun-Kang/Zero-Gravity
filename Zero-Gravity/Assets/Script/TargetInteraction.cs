using UnityEngine;

public class TargetInteraction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private Rigidbody rb;
    private BoxCollider col;
    void Start()
    {
        if( rb == null) rb = GetComponent<Rigidbody>();
        if( col == null ) col = GetComponent<BoxCollider>();

    }

    private void ZeroGravity()
    {
        print("Zero-Gravity-Mode");
    }

    //
    void Update()
    {
        if (col != null)
        {
            ZeroGravity();
        }
    }
}
