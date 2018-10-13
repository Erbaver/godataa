using GoData.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace GoData.Api.Tests
{
    public class WebHookControllerShould
    {
        [Fact]
        public void ReturnWelcomeMessage()
        {
            var _controller = new WebHookController();
            var @params = new Dictionary<string, string>();
            var response = _controller.Post(@params);

            Assert.Equal("END Welcome to GoData Analytica, please enter your Form Id", response.Content);
        }
    }
}
