namespace Ejemplo_MiILogger.Services;

public interface ILogReaderService
{
    string ReadLogs();
    void ClearLogs();
}