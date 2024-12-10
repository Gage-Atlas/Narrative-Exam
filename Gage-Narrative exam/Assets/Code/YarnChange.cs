qusing UnityEngine;
using UnityEngine.Audio;
using Yarn.Unity;

public class YarnChange : MonoBehaviour
{
    [YarnCommand("on")]
    public void TurnOnGameObject(string objectName)
    {
        GameObject targetObject = GameObject.Find(objectName);
        if (targetObject != null) targetObject.transform.GetChild(0).gameObject.SetActive(true);
    }
