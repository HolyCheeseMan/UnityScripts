using UnityEngine;

public class Torch : MonoBehaviour
{
    public bool torchOn = true;
    public Light spotLight;
    public Light torchLight;
    public Light torchLight2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            torchOn = !torchOn;
        }
        spotLight.enabled = torchOn;
        torchLight.enabled = torchOn;
        torchLight2.enabled = torchOn;
    }
}
