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
    public void SetWeapon(string currentweapon)
    {
        if (currentweapon == "rustysword")
        {
            // met for loop wapen uit weapon lijst halen en in fields zetten (kon miss ook gwn in de constructor oops)
            foreach (Weapon weapon in World.Weapons)
            {
                if (weapon.Name == "Rusty sword")
                {
                    this.ID = weapon.ID;
                    this.Name = weapon.Name;
                    this.NamePlural = weapon.NamePlural;
                    this.MinimumDamage = weapon.MinimumDamage;
                    this.MaximumDamage = weapon.MaximumDamage;
                }
            }
        }
        else if (currentweapon == "gun")
        {
            foreach (Weapon weapon in World.Weapons)
            {
                if (weapon.Name == "Club")
                {
                    this.ID = weapon.ID;
                    this.Name = weapon.Name;
                    this.NamePlural = weapon.NamePlural;
                    this.MinimumDamage = weapon.MinimumDamage;
                    this.MaximumDamage = weapon.MaximumDamage;
                }
            }
        }
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
