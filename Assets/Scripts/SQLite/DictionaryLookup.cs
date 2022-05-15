using SQLite4Unity3d;

public class DictionaryLookup
{

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sprite { get; set; }
    public bool isFairy { get; set; }
    public bool isBackground { get; set; }
    public bool isCommand { get; set; }
    public bool isEffect { get; set; }


    public override string ToString()
    {
        return string.Format("[DL: Id={0}, Name={1}, Sprite={2}, isFairy={3}]", Id, Name, Sprite, isFairy);
    }
}
