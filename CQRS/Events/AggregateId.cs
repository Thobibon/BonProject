namespace BonProject.CQRS.Events;

public abstract record AggregateId
{
    public AggregateId(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("AggregateId cannot be Guid.Empty");
        this.Value = value;
    }

    public Guid Value { get; init; }
}