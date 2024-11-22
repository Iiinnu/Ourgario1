using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    public TMP_InputField hostIpInputField;
    public void OnButtonClick()
    {
        GameSession.JoinGame(hostIpInputField.text);
    }
    
}
