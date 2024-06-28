﻿using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.AddressDtos;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UILayoutFooterComponent:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _UILayoutFooterComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7054/api/Address");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAddressDto>>(jsonData);
                return View(values.FirstOrDefault());
            }
            return View();
        }
    }
}
