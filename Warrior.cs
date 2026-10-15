namespace id2;

/// <summary>
/// Воин — персонаж с высокой защитой, способный лечиться.
/// </summary>
public class Warrior : Character, IHealable
{
private int _armor;

/// <summary>
/// Количество брони воина.
/// </summary>
public int Armor
{
    get => _armor;
    set => _armor = value;
}

/// <summary>
/// Признак того, что воин является «танком» (много здоровья и брони).
/// </summary>
public bool IsTank => Armor >= 10 && Health >= 100;

/// <summary>
/// Инициализирует нового воина с указанными параметрами.
/// </summary>
/// <param name="id">Уникальный идентификатор.</param>
/// <param name="name">Имя.</param>
/// <param name="health">Здоровье.</param>
/// <param name="armor">Броня.</param>
public Warrior(int id, string name, int health, int armor) : base(id, name, health)
{
    _armor = armor;
    Class = CharacterClass.Warrior;
}

/// <summary>
/// Инициализирует нового воина со значениями по умолчанию: health = 100, armor = 10.
/// </summary>
/// <param name="name">Имя.</param>
public Warrior(string name) : this(0, name, 100, 10)
{
}

/// <summary>
/// Воин наносит удар мечом.
/// </summary>
public override void Attack()
{
    Console.WriteLine($"{Name} swings sword.");
}

/// <summary>
/// Восстанавливает здоровье воина, если он жив.
/// </summary>
/// <param name="amount">Количество восстанавливаемых очков здоровья.</param>
public void Heal(int amount)
{
    if (!IsAlive)
    {
        Console.WriteLine($"{Name} cannot be healed.");
        return;
    }

    Health += amount;
    Console.WriteLine($"{Name} healed by {amount}.");
}

/// <summary>
/// Возвращает строковое представление воина с учётом брони.
/// </summary>
/// <returns>Строка с описанием персонажа.</returns>
public override string ToString()
{
    return $"[{Class}] {Name}, HP={Health}, class: {Class}, armor={Armor}\n" +
           $"  alive: {IsAlive}, tank: {IsTank}";
}
}