﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ziggeo.Xamarin.NetStandard.Demo.Models;

namespace Ziggeo.Xamarin.NetStandard.Demo.Services
{
    public class CloudDataStore : IDataStore<VideoItem>
    {
        List<VideoItem> items;

        public CloudDataStore()
        {
            items = new List<VideoItem>();
        }

        public async Task<IEnumerable<VideoItem>> Index()
        {
            items.Clear();
            items.AddRange((await App.ZiggeoApplication.Videos.Index(null)).Select(jsonObj => new VideoItem() { token = jsonObj["token"].ToString() }));
            return items;
        }

        public void AddCachedItem(VideoItem item)
        {
            items.Add(item);
        }

        public async Task<bool> Delete(string token)
        {
            try
            {
                await App.ZiggeoApplication.Videos.Destroy(token);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}