using UnityEngine;

public class TestScript : MonoBehaviour {
    [SerializeField] private Rigidbody myRigi;
    [SerializeField] private float forceValue;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            Push();
        }
    }

    private void Push()
    {
        myRigi.velocity = Vector3.forward * forceValue;
    }
}
