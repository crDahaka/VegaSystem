namespace VegaSystem.Persistence.UnitOfWork
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}