namespace Kokin.Core
{
    public interface ILogInterface
    {
        ILogInterface Log(string message);
        ILogInterface Write();
    }
}