﻿using SISEcommerce.Web.Helpers;
using SISEcommerce.Web.Models;
using SISEcommerce.Web.Models.Catalog;
using SISEcommerce.Web.Services.Interfaces;
using SISECommerce.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Services
{
    public class CatalogService : ICatalogService
    {

        private readonly HttpClient _client;
        private readonly IPhotoStockService _photoStockService;
        private readonly PhotoHelper _photoHelper;
        public CatalogService(HttpClient client, IPhotoStockService photoStockService, PhotoHelper photoHelper)
        {
            _client = client;
            _photoStockService = photoStockService;
            _photoHelper = photoHelper; 
        }

        public async Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput)
        {

            var resultPhotoService = await _photoStockService.UploadPhoto(courseCreateInput.PhotoFormFile);
            if (resultPhotoService != null)
            {
                courseCreateInput.Picture = resultPhotoService.Url;
            }

            var response = await _client.PostAsJsonAsync<CourseCreateInput>("courses", courseCreateInput);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCourseAsync(string courseId)
        {
            var response = await _client.DeleteAsync($"courses/{courseId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<CategoryViewModel>> GetAllCategoryAsync()
        {
            var response = await _client.GetAsync("categories");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<CategoryViewModel>>>();
 
            return responseSuccess.Data;
        }

        public async Task<List<CourseViewModel>> GetALlCourseAsync()
        {
            var response = await _client.GetAsync("courses");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<CourseViewModel>>>();
            responseSuccess.Data.ForEach(x =>
            {
                x.Picture = _photoHelper.GetPhotoStockUrl(x.Picture);
            });
            return responseSuccess.Data;
        }

        public async Task<List<CourseViewModel>> GetALlCourseByUserIdAsync(string userId)
        {
            var response = await _client.GetAsync($"courses/GetAllByUserId/{userId}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<CourseViewModel>>>();
            responseSuccess.Data.ForEach(x =>
            {
                x.Picture = _photoHelper.GetPhotoStockUrl(x.Picture);
            });
            return responseSuccess.Data;
        }

        public async Task<CourseViewModel> GetByCourseId(string courseId)
        {
            var response = await _client.GetAsync($"courses/{courseId}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<CourseViewModel>>();
            return responseSuccess.Data;
        }

        public async Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput)
        {
            var response = await _client.PutAsJsonAsync<CourseUpdateInput>("courses", courseUpdateInput);
            return response.IsSuccessStatusCode;
        }
    }
}
