using UnityEngine;
using UnityEngine.UI;

public class Check_continue_posibility : MonoBehaviour
{
    void Start()
    {
        if(Find_file.Exist("Text_files/User_data/user.json"))
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
