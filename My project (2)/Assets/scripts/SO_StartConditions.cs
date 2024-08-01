using UnityEngine;

[CreateAssetMenu(fileName = "Start Conditions", menuName = "Scriptable Objects/Start Conditions")] 
public class SO_StartConditions : ScriptableObject
{
    public enum StartCondition {
        None,
        SkipIntro,
        BossFight,
    }
    public StartCondition startCondition;
    public enum StartLocation {
        None,
        Tower,
    }
    public StartLocation startLocation;
}
