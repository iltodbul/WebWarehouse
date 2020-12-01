namespace WebWarehouse.Services.Data.Transfers
{
    using System.Threading.Tasks;

    using WebWarehouse.Web.ViewModels.Transfers;

    public interface ITransfersService
    {
        Task MakeTransfer(TransferInputModel inputModel);
    }
}
