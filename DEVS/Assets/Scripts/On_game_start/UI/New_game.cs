using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class New_game : MonoBehaviour
{
    private GameObject Panel_buttons;
    private GameObject Panel_new_game;

    private Image img_easy_selected;
    private Image img_medium_selected;
    private Image img_hard_selected;

    public void Start()
    {
        Panel_buttons = GameObject.Find("Buttons_panel");
        Panel_new_game = GameObject.Find("Panel_new_game");

        img_easy_selected = GameObject.Find("img_easy_selected").GetComponent<Image>();
        img_medium_selected = GameObject.Find("img_medium_selected").GetComponent<Image>();
        img_hard_selected = GameObject.Find("img_hard_selected").GetComponent<Image>();

        img_easy_selected.enabled = false;
        img_medium_selected.enabled = false;
        img_hard_selected.enabled = false;

        Panel_new_game.SetActive(false);

    }

    public void On_press_new_game()
    {
        if(Find_file.Exist("Text_files/User_data/user.json"))
        {
            Debug.Log("Exista un json deja");
            //are you sure ?
        }
        else
        {
            Debug.Log("Se deschide interfata");
            Open_new_game_menu();
        }
    }

    private void Open_new_game_menu()
    {
        Panel_buttons.SetActive(false);
        Panel_new_game.SetActive(true);
    }

    public void On_easy_select()
    {
        img_easy_selected.enabled = true;
        img_medium_selected.enabled = false;
        img_hard_selected.enabled = false;
    }

    public void On_medium_select()
    {
        img_easy_selected.enabled = false;
        img_medium_selected.enabled = true;
        img_hard_selected.enabled = false;
    }

    public void On_hard_select()
    {
        img_easy_selected.enabled = false;
        img_medium_selected.enabled = false;
        img_hard_selected.enabled = true;
    }

    public void Remade_text_color()
    {
        if(GameObject.Find("Name_input").GetComponent<InputField>().placeholder.color == Color.red)
        {
            GameObject.Find("Name_input").GetComponent<InputField>().placeholder.color = Color.black;
        }
    }

    public void Confirm()
    {
        if(GameObject.Find("Name_input").GetComponent<InputField>().text.Length<=0)
        {
            GameObject.Find("Name_input").GetComponent<InputField>().placeholder.color = Color.red;
        }
        else
        {
            Continue();
        }
    }

    private void Continue()
    {
        Player_data data;
        if (img_easy_selected.enabled)
        {
            data = Easy_selected();
        }
        else if(img_medium_selected.enabled)
        {
            data = Medium_selected();
        }
        else
        {
            data = Hard_selected();
        }
        Create_json(data);
        Enter_the_map();
    }

    public void Continue_with_data()
    {
        SceneManager.LoadScene(1);
    }

    private void Enter_the_map()
    {
        SceneManager.LoadScene(1);
    }

    private void Create_json(Player_data data)
    {
        string json = JsonUtility.ToJson(data,true);
        System.IO.File.WriteAllText(Application.dataPath + "/Resources/Text_files/User_data/user.json", json);
    }

    private Player_data Easy_selected()
    {
        Player_data data = new Player_data();
        data.Hp = 100;
        data.Id_arma = 0;
        data.Id_dificultate = 0;//easy
        //data.Id_iteme_inventar = null;
        data.Id_outfit = 0;
        data.Locatia = new Vector3(0, 0, 0);
        data.Munitia = 0;
        data.Name = GameObject.Find("Name_input").GetComponent<InputField>().text;
        data.Nivel = 0;
        data.Skillpoints = 0;
        data.Stamina = 100;
        data.Xp = 0;
        return data;
    }
    private Player_data Medium_selected()
    {
        Player_data data = new Player_data();
        data.Hp = 100;
        data.Id_arma = 0;
        data.Id_dificultate = 1;//medium
        //data.Id_iteme_inventar = null;
        data.Id_outfit = 0;
        data.Locatia = new Vector3(0, 0, 0);
        data.Munitia = 0;
        data.Name = GameObject.Find("Name_input").GetComponent<InputField>().text;
        data.Nivel = 0;
        data.Skillpoints = 0;
        data.Stamina = 100;
        data.Xp = 0;
        return data;
    }
    private Player_data Hard_selected()
    {
        Player_data data = new Player_data();
        data.Hp = 100;
        data.Id_arma = 0;
        data.Id_dificultate = 2;//hard
        //data.Id_iteme_inventar = null;
        data.Id_outfit = 0;
        data.Locatia = new Vector3(0, 0, 0);
        data.Munitia = 0;
        data.Name = GameObject.Find("Name_input").GetComponent<InputField>().text;
        data.Nivel = 0;
        data.Skillpoints = 0;
        data.Stamina = 100;
        data.Xp = 0;
        return data;
    }
}
