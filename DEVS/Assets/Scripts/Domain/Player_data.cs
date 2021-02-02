using System;
using UnityEngine;

[Serializable]
public class Player_data
{
    public int nivel;
    public string name;
    public int xp;
    public int skillpoints;
    public int id_outfit;
    //int[] id_iteme_inventar;
    public int stamina;
    public int hp;
    public int id_dificultate;
    public Vector3 locatia;
    public int munitia;
    public int id_arma;

    public int Nivel { get => nivel; set => nivel = value; }
    public string Name { get => name; set => name = value; }
    public int Xp { get => xp; set => xp = value; }
    public int Skillpoints { get => skillpoints; set => skillpoints = value; }
    public int Id_outfit { get => id_outfit; set => id_outfit = value; }
    //public int[] Id_iteme_inventar { get => id_iteme_inventar; set => id_iteme_inventar = value; }
    public int Stamina { get => stamina; set => stamina = value; }
    public int Hp { get => hp; set => hp = value; }
    public int Id_dificultate { get => id_dificultate; set => id_dificultate = value; }
    public Vector3 Locatia { get => locatia; set => locatia = value; }
    public int Munitia { get => munitia; set => munitia = value; }
    public int Id_arma { get => id_arma; set => id_arma = value; }
}
