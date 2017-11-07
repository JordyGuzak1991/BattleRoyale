using UnityEngine;

public class Item {
    public Sprite Sprite;
    public string Title;
    public string Description;
    public int Amount = 1;
    public bool Stackable;

    public Item()
    {
    }

    public Item(Sprite sprite, string title, string description, int amount, bool stackable)
    {
        Sprite = sprite;
        Title = title;
        Description = description;
        Amount = amount;
        Stackable = stackable;
    }

    public override void Interact()
    {
        EventManager.Instance.Invoke(
            new PickUpItemEvent(
            new Item(
                Sprite, 
                Title, 
                Description, 
                Amount, 
                Stackable
            )));
    }
}
