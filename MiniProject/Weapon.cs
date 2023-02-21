public class Weapon
{
    public int ID;
    public string? Name;
    public string? NamePlural;
    public int MinimumDamage;
    public int MaximumDamage;

    public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MinimumDamage = minimumDamage;
        MaximumDamage = maximumDamage;
    }


    // method om weapon te intialisen
    // geef aan het begin string mee met welke en als je een ander weapon krijgt veranderd het
    public void SetWeapon(int weaponid)
    {

        World.WeaponByID(weaponid);

    }


    // method om damage te doen
    public int DoDamage()
    {
        Random attackRange = new Random();
        // random damage kiezen tussn min en max
        int damageValue = attackRange.Next(this.MinimumDamage, this.MaximumDamage);
        // damage van monster hp afhalen

        // via class monster of gwn int returnen?
        return damageValue;
    }
}
