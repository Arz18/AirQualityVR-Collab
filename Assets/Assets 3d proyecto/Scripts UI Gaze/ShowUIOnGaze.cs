using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ShowUIOnGaze : MonoBehaviour
{
    [Header("UI que quiero mostrar")]
    public GameObject infoUIPanel;   // Arrastra aquí tu Canvas/Panel en el Inspector

    private XRBaseInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
    }

    private void OnEnable()
    {
        if (interactable != null)
        {
            interactable.hoverEntered.AddListener(OnHoverEntered);
            interactable.hoverExited.AddListener(OnHoverExited);
        }
    }

    private void OnDisable()
    {
        if (interactable != null)
        {
            interactable.hoverEntered.RemoveListener(OnHoverEntered);
            interactable.hoverExited.RemoveListener(OnHoverExited);
        }
    }

    private void OnHoverEntered(HoverEnterEventArgs args)
    {
        if (infoUIPanel != null)
            infoUIPanel.SetActive(true);
    }

    private void OnHoverExited(HoverExitEventArgs args)
    {
        if (infoUIPanel != null)
            infoUIPanel.SetActive(false);
    }
}
