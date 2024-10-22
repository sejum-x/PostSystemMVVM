using AutoMapper;
using PostSystemMVVM.Model;
using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Base
{
    public class Mapping
    {
        private readonly IMapper _mapper;

        public Mapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Branch, BranchViewModel>();
                cfg.CreateMap<BranchViewModel, Branch>();

                cfg.CreateMap<Worker, WorkerViewModel>();
                cfg.CreateMap<WorkerViewModel, Worker>();

                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<ClientViewModel, Client>();

                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<OrderViewModel, Order>();
            });

            _mapper = config.CreateMapper();
        }

        public IMapper GetMapper()
        {
            return _mapper; 
        }
    }
}