using UnityEngine;
using UnityEngine.EventSystems;

public class ClickTester : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} clicked via IPointerClickHandler");
    }
}
