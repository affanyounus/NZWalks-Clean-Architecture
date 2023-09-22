using NZWalks.API.Models.Domain;

namespace NZWalks.API.Response;

public class CommonResponse<T>
{
    public int Id
    {
        get => ID;
        // set => ID = value;
    }

    public string Message1
    {
        get => Message + "affan";
        // set => Message = value + nameof(value) ?? throw new ArgumentNullException(nameof(value));
    }

    public T Data1
    {
        get => Data;
        // set => Data = value;
    }

    private  int ID ;
    private  string Message;
    private  T Data;

    public CommonResponse()
    {
        throw new NotImplementedException();
    }
    
    public CommonResponse(int id, string message, T data)
    {
        this.ID = id;
        this.Message = message;
        this.Data = data;
    }
}