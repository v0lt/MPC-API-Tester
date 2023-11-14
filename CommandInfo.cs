public class CommandInfo
{
    private MPCAPI_COMMAND id;
    private string desc;
    private string extradesc;

    public CommandInfo(MPCAPI_COMMAND id, string desc, string extradesc = "")
    {
        this.id = id;
        this.desc = desc;
        this.extradesc = extradesc;
    }

    public MPCAPI_COMMAND Id => id;
    public string Desc => desc;
    public string ExtraDesc => extradesc;
    public string IdString()
    {
        return id.ToString();
    }
}