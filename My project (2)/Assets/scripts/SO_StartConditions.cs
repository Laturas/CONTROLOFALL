using UnityEngine;

[CreateAssetMenu(fileName = "Start Conditions", menuName = "Scriptable Objects/Start Conditions")] 
public class SO_StartConditions : ScriptableObject
{
    public enum StartCondition {
        None,
        SkipIntro,
    }
    public StartCondition startCondition;
}
