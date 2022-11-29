﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MovieExternalApi;
//
//    var movieApi = MovieApi.FromJson(jsonString);

namespace MovieExternalApi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class MovieApi
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fullTitle")]
        public string FullTitle { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("crew")]
        public string Crew { get; set; }

        [JsonProperty("imDbRating")]
        public string ImDbRating { get; set; }

        [JsonProperty("imDbRatingCount")]
        public long ImDbRatingCount { get; set; }
    }

    public partial class MovieApi
    {
        public static MovieApi FromJson(string json) => JsonConvert.DeserializeObject<MovieApi>(json, MovieExternalApi.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this MovieApi self) => JsonConvert.SerializeObject(self, MovieExternalApi.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}