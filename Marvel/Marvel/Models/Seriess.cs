﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Seriess
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class TextObject
    {
        [JsonProperty ( "type" )]
        public string Type { get; set; }

        [JsonProperty ( "language" )]
        public string Language { get; set; }

        [JsonProperty ( "text" )]
        public string Text { get; set; }
    }

    public class Urls
    {
        [JsonProperty ( "type" )]
        public string Type { get; set; }

        [JsonProperty ( "url" )]
        public string Url { get; set; }
    }

    public class Series
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }
    }

    public class Variant
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }
    }

    public class Collection
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }
    }

    public class CollectedIssue
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }
    }

    public class Dates
    {
        [JsonProperty ( "type" )]
        public string Type { get; set; }

        [JsonProperty ( "date" )]
        public object Date { get; set; }
    }

    public class Prices
    {
        [JsonProperty ( "type" )]
        public string Type { get; set; }

        [JsonProperty ( "price" )]
        public double Price { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty ( "path" )]
        public string Path { get; set; }

        [JsonProperty ( "extension" )]
        public string Extension { get; set; }
    }

    public class Image
    {
        [JsonProperty ( "path" )]
        public string Path { get; set; }

        [JsonProperty ( "extension" )]
        public string Extension { get; set; }
    }

    public class Item
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }

        [JsonProperty ( "role" )]
        public string Role { get; set; }

        [JsonProperty ( "type" )]
        public string Type { get; set; }
    }

    public class Creators
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Characters
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Stories
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Events
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<object> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Result
    {
        [JsonProperty ( "id" )]
        public int Id { get; set; }

        [JsonProperty ( "digitalId" )]
        public int DigitalId { get; set; }

        [JsonProperty ( "title" )]
        public string Title { get; set; }

        [JsonProperty ( "issueNumber" )]
        public int IssueNumber { get; set; }

        [JsonProperty ( "variantDescription" )]
        public string VariantDescription { get; set; }

        [JsonProperty ( "description" )]
        public string Description { get; set; }

        [JsonProperty ( "modified" )]
        public object Modified { get; set; }

        [JsonProperty ( "isbn" )]
        public string Isbn { get; set; }

        [JsonProperty ( "upc" )]
        public string Upc { get; set; }

        [JsonProperty ( "diamondCode" )]
        public string DiamondCode { get; set; }

        [JsonProperty ( "ean" )]
        public string Ean { get; set; }

        [JsonProperty ( "issn" )]
        public string Issn { get; set; }

        [JsonProperty ( "format" )]
        public string Format { get; set; }

        [JsonProperty ( "pageCount" )]
        public int PageCount { get; set; }

        [JsonProperty ( "textObjects" )]
        public List<TextObject> TextObjects { get; set; }

        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "urls" )]
        public List<Urls> Urls { get; set; }

        [JsonProperty ( "series" )]
        public Series Series { get; set; }

        [JsonProperty ( "variants" )]
        public List<Variant> Variants { get; set; }

        [JsonProperty ( "collections" )]
        public List<Collection> Collections { get; set; }

        [JsonProperty ( "collectedIssues" )]
        public List<CollectedIssue> CollectedIssues { get; set; }

        [JsonProperty ( "dates" )]
        public List<Dates> Dates { get; set; }

        [JsonProperty ( "prices" )]
        public List<Prices> Prices { get; set; }

        [JsonProperty ( "thumbnail" )]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty ( "images" )]
        public List<Image> Images { get; set; }

        [JsonProperty ( "creators" )]
        public Creators Creators { get; set; }

        [JsonProperty ( "characters" )]
        public Characters Characters { get; set; }

        [JsonProperty ( "stories" )]
        public Stories Stories { get; set; }

        [JsonProperty ( "events" )]
        public Events Events { get; set; }
    }

    public class Data
    {
        [JsonProperty ( "offset" )]
        public int Offset { get; set; }

        [JsonProperty ( "limit" )]
        public int Limit { get; set; }

        [JsonProperty ( "total" )]
        public int Total { get; set; }

        [JsonProperty ( "count" )]
        public int Count { get; set; }

        [JsonProperty ( "results" )]
        public List<Result> Results { get; set; }
    }

    public class Root
    {
        [JsonProperty ( "code" )]
        public int Code { get; set; }

        [JsonProperty ( "status" )]
        public string Status { get; set; }

        [JsonProperty ( "copyright" )]
        public string Copyright { get; set; }

        [JsonProperty ( "attributionText" )]
        public string AttributionText { get; set; }

        [JsonProperty ( "attributionHTML" )]
        public string AttributionHTML { get; set; }

        [JsonProperty ( "etag" )]
        public string Etag { get; set; }

        [JsonProperty ( "data" )]
        public Data Data { get; set; }
    }


}
