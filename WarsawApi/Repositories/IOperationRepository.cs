using WarsawApi.Dto.Operation;
using WarsawApi.Entities;

namespace WarsawApi.Repositories
{
    public interface IOperationRepository
    {
        IEnumerable<OperationEntity> GetAllOperations();
        OperationEntity GetOperationById(int id);
        OperationEntity CreateOperation(CreateOperationDto dto);
        OperationEntity UpdateOperation(UpdateOperationDto dto);
        void DeleteOperation(int id);
    }
}
