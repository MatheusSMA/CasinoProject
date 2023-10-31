
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Item row")]
public class Slot : ScriptableObject
{
    [Range(0, 100)]
    [SerializeField] private int _chance = 0;
    [SerializeField] private int _multiply;
    [SerializeField] private Color _color;

    public int Chance { get => _chance; set => _chance = value; }
    public int Multiply { get => _multiply; set => _multiply = value; }
    public Color Color { get => _color; set => _color = value; }
}