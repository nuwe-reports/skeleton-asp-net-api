using FluentAssertions;
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CleanArchitecture.WebApi;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CleanArchitecture.Application.IntegrationTests.Controllers
{
    public class ExampleControllerTests
    {
        [Test, Category("e2e")]
        public async Task ShouldReturnCorrectExampleString()
        {
            await using var application = new WebApplicationFactory<Program>();
            var client = application.CreateClient();
            
            var responseMessage = await client.GetAsync("/api/health");
            
            Assert.AreEqual("2", responseMessage.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(HttpStatusCode.OK, responseMessage.StatusCode);
        }
    }
}