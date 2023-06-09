using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class TMPBoundingBoxVisualizer : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private RectTransform rectTransform;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        rectTransform = GetComponent<RectTransform>();
    }

    private void OnDrawGizmos()
    {
        if (textMeshPro != null && rectTransform != null)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(rectTransform.rect.center, rectTransform.rect.size);
        }
    }
}
