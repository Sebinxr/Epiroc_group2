using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class ButtonController : MonoBehaviour
{
    public XROrigin xrOrigin;
    public DynamicMoveProvider dynamicMoveProvider;

    public void OnButtonClick()
    {
        dynamicMoveProvider.enabled = true;
    }
}
