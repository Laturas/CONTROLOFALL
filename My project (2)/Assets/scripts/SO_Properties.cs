using UnityEngine;

[CreateAssetMenu(fileName = "Properties", menuName = "Scriptable Objects/Properties")] 
public class SO_Properties : ScriptableObject
{
    public Color highlightedBlockColor;
    public Color activatedBlockColor;
    public Color highlightedActiveBlockColor;
    public Color inactiveBlockColor;
}
