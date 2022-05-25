using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Ping.Repositories;

namespace CleanArchitecture.Application.Ping.Queries
{
    public class GetPingQuery : IRequest<int>
    {
    }

    public class GetExampleQueryQueryHandler : IRequestHandler<GetPingQuery, int>
    {
        private IRepository repository;

        public GetExampleQueryQueryHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(GetPingQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetQueryAsync();
        }
    }
}