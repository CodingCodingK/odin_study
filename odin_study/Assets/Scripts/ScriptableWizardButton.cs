using UnityEngine;
using UnityEditor;
using System.Collections;

public class ScriptableWizardButton : ScriptableWizard
{
    public Transform firstObject = null;
    public Transform secondObject = null;

    [MenuItem("Example/Show OnWizardOtherButton Usage")]
    static void CreateWindow()
    {
        ScriptableWizard.DisplayWizard("Click info to know the distance between the objects", typeof(ScriptableWizardButton), "Finish!", "Info");
    }

    void OnWizardUpdate()
    {
        if (firstObject == null || secondObject == null)
        {
                isValid = false;
            errorString = "Select the objects you want to measure";
        }
        else
        {
                isValid = true;
            errorString = "";
        }
    }
    // Called when you press the "Info" button.
    void OnWizardOtherButton()
    {
        float distanceObjs = Vector3.Distance(firstObject.position, secondObject.position);
        EditorUtility.DisplayDialog(
            "The distance between the objects is: " + distanceObjs + " Units",
            "",
            "Ok");
    }
    // Called when you press the "Finish!" button.
    void OnWizardCreate()
    {
        EditorUtility.DisplayDialog("OnWizardCreate ", "", "Ok");
    }
}