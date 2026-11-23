using UnityEngine;

[CreateAssetMenu(fileName = "Movement Profile", menuName = "Scriptable Objects/Movement Profile")]
public class MovementProfile : ScriptableObject
{
    [SerializeField] [Min(0f)] private float speed = 2f;
    [SerializeField] [Min(0f)] private float distance = 1.5f;
    [SerializeField] private Color color = Color.cyan;
    [SerializeField] [Min(0f)] private float glowIntensity = 2.5f;

    public Color GlowColor => new Color(
        color.r * glowIntensity,
        color.g * glowIntensity,
        color.b * glowIntensity,
        color.a);

    public Vector3 GetPosition(Vector3 center, float time)
    {
        float offset = Mathf.Sin(time * speed) * distance;

        return center + Vector3.right * offset;
    }
}
