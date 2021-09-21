using DixseptData;

namespace dixseptManagement.Service
{

    public interface IBaseService
    {
    }
    public class BaseService : IBaseService
    {
        protected IUnitOfWork _uow;

        public BaseService() { 
            // 各サーボスクラスのコンストラクタでUnitOfWorkサービスを詰める
        }
    }
}
