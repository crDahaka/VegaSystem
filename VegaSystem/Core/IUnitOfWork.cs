namespace VegaSystem.Core
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}