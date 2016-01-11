namespace MultiplayerMain
{
    public interface IClient
    {
        bool IsWaiting { get; set; }
        bool Syncronise(params object[] data);

    }
}