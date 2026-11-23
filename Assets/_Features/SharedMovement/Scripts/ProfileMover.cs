using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ProfileMover : MonoBehaviour
{
    [SerializeField] private MovementProfile profile;

    private Vector3 center;

    private void Awake()
    {
        if (profile == null)
        {
            Debug.LogError($"У {name} не назначен MovementProfile", this);
            enabled = false;
            return;
        }

        center = transform.position;
        var meshRenderer = GetComponent<MeshRenderer>();
        var colorBlock = new MaterialPropertyBlock();
        colorBlock.SetColor("_BaseColor", profile.GlowColor);
        meshRenderer.SetPropertyBlock(colorBlock);
    }

    private void Update()
    {
        transform.position = profile.GetPosition(center, Time.time);
    }
}
