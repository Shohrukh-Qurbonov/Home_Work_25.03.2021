using System.Collections.Generic;


namespace WebApplication.Models
{
    public interface IDbReader<T>
    {
        List<T> ReadAll();
    }
}