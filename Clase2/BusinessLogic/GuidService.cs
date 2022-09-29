using IBusinessLogic;

namespace BusinessLogic;

public class GuidService:IGuidService
{
    public Guid NewGuid() { return Guid.NewGuid(); }
    
}