using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Ping.Repositories;

namespace CleanArchitecture.Application.Ping.Queries
{
    public class GetPingQueryRequest : IRequest<int>
    {
    }

    public class GetPingQueryHandler : IRequestHandler<GetPingQueryRequest, int>
    {
        private IRepository repository;

        public GetPingQueryHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetPingQueryRequest request, CancellationToken cancellationToken)
        {
            return await repository.GetQueryAsync();
        }
    }
}