namespace WebWarehouse.Services.Data.Transfers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WebWarehouse.Web.ViewModels.Transfers;

    public interface ITransfersService
    {
        Task MakeTransfer(TransferInputModel inputModel, string userId);

        Task<IEnumerable<T>> GetAllAsync<T>();
    }
}
