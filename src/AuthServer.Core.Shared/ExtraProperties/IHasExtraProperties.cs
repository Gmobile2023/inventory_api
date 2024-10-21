namespace AuthServer.ExtraProperties
{
    public interface IHasExtraProperties
    {
        ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}