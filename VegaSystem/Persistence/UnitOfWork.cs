namespace VegaSystem.Persistence.UnitOfWork
{
    using System.Threading.Tasks;
    using VegaSystem.Core;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly VegaDbContext context;

        public UnitOfWork(VegaDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}