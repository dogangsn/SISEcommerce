using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using SISECommerce.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SISEcommerce.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbConnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }

        public Task<Response<NoContent>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<Models.Discount>>> GetAll()
        {
            var discount = await _dbConnection.QueryAsync<Models.Discount>("Select * from discount");
            return Response<List<Models.Discount>>.Success(discount.ToList(), 204);
        }

        public Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId)
        {


            throw new NotImplementedException();
        }

        public async Task<Response<Models.Discount>> GetById(int id)
        {
            var discount = (await _dbConnection.QueryAsync<Models.Discount>("Select * from discount where id=@Id", new { Id = id })).SingleOrDefault();
            if (discount == null)
            {
                return Response<Models.Discount>.Fail("Discount Not Found", 404);
            }
            return Response<Models.Discount>.Success(discount, 200);
        }

        public async Task<Response<NoContent>> Save(Models.Discount discount)
        {
            var saveStatus = await _dbConnection.ExecuteAsync("INSERT INTO discount (userid,rate,code) VALUES (@userId,@Rate,@Code", discount);
            if (saveStatus > 0)
                return Response<NoContent>.Success(204);
            return Response<NoContent>.Fail("an error accured while adding", 500);
        }

        public Task<Response<NoContent>> Update(Models.Discount discount)
        {
            throw new NotImplementedException();
        }
    }
}
