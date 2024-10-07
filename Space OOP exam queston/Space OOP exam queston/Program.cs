internal class Program
{
    private static void Main(string[] args)
    {
        
    }

}
class Space_objects
{
    private string Name;
    private int hit_points;

    public Space_objects(string NEW_name, int NEW_hit_points)//constructor
    {
        this.Name = NEW_name;
        this.hit_points = NEW_hit_points;
    }
    public string GET_name() { return Name; }
    public void SET_name(string DIFF_name) 
    { 
        this.Name = DIFF_name;
    }
    public int GET_hit_points() { return hit_points; }
    public void SET_hit_points(int DIFF_hit_points)
    {
        this.hit_points = DIFF_hit_points;
    }
}
class Alien_ship : Space_objects
{
    private int speed;
    private int damage;
    private bool friendly;

    public Alien_ship(string NEW_name, int NEW_hit_points, int NEW_speed, int NEW_damage, bool NEW_friendly) : base(NEW_name, NEW_hit_points)//constructor
    {
        this.speed = NEW_speed;
        this.damage = NEW_damage;
        this.friendly = NEW_friendly;

    }
    public int GET_speed() { return speed; }
    public void SET_speeds(int DIFF_speed)
    {
        this.speed = DIFF_speed;
    }
    public int GET_damage() { return damage; }
    public void SET_damage(int DIFF_damage)
    {
        this.damage = DIFF_damage;
    }
    public bool GET_friendly() {return friendly;}
    public void SET_friendly(bool DIFF_friendly)
    {
        this.friendly = DIFF_friendly;
    }
}