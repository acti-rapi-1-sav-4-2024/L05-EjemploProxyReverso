namespace EjemploProxyReverso;

public interface IPoetryService
{
    Task<string> GetAuthorsAsync();
}