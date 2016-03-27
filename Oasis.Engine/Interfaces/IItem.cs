namespace Oasis.Engine.Interfaces
{
    interface IItem
    {
        string Name { get; set; }
        string NamePlural { get; set; }
        string Description { get; set; }
        int Value { get; set; }
        
    }
}
