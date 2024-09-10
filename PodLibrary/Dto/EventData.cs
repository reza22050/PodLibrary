using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodLibrary
{
    public class StoreProductUpdateEvent
    {
        public string EventName { get; set; }
        public EventData EventData { get; set; }
    }

    public class EventData
    {
        public string Title { get; set; }
        public string VariantTitle { get; set; }
        public string ShortDescription { get; set; }
        public string TitleEn { get; set; }
        public string SubTitle { get; set; }
        public List<string> Publications { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageTitle { get; set; }
        public List<string> TableOfContents { get; set; }
        public string Type { get; set; }
        public string ParentSku { get; set; }
        public string Slug { get; set; }
        public int? EditionNumber { get; set; }
        public int PrintNumber { get; set; }
        public int PrintYear { get; set; }
        public int PrintMonth { get; set; }
        public string PrintCity { get; set; }
        public int PrintCirculation { get; set; }
        public int PageCount { get; set; }
        public string BookSize { get; set; }
        public string BookSizeDisplayName { get; set; }
        public int WidthMm { get; set; }
        public int LengthMm { get; set; }
        public int? WeightGr { get; set; }
        public string CoverType { get; set; }
        public string BindingType { get; set; }
        public string TextPaperType { get; set; }
        public string TextColor { get; set; }
        public string Isbn { get; set; }
        public string Isbn10 { get; set; }
        public string Ddc { get; set; }
        public int? VolumeCount { get; set; }
        public int? VolumeNumber { get; set; }
        public decimal Price { get; set; }
        public string Summery { get; set; }
        public string Format { get; set; }
        public string ProductType { get; set; }
        public List<string> Tags { get; set; }
        public Agents Agents { get; set; }
        public List<string> Attachment { get; set; }
        public string PrintIn { get; set; }
        public List<string> LiteraryAwards { get; set; }
        public Review Review { get; set; }
        public List<File> Files { get; set; }
        public Categories Categories { get; set; }
        public Store Store { get; set; }
        public Pod Pod { get; set; }
    }

    //public class Agents
    //{
    //    public List<string> Author { get; set; }
    //}

    //public class Review
    //{
    //    public Rating Rating { get; set; }
    //    public List<string> Files { get; set; }
    //    public List<Comment> Comments { get; set; }
    //}

    //public class Rating
    //{
    //    public int Score { get; set; }
    //    public int Count { get; set; }
    //}

    //public class Comment
    //{
    //    public string User { get; set; }
    //    public string CommentText { get; set; }
    //}

    //public class File
    //{
    //    public string Src { get; set; }
    //    public string Title { get; set; }
    //    public string Size { get; set; }
    //    public string Type { get; set; }
    //}


    //public class Categories
    //{
    //    public Category MainCategory { get; set; }
    //    public List<SubCategory> SubCategory { get; set; }
    //    public AgeClassification AgeClassification { get; set; }
    //    public string AgeGroup { get; set; }
    //}

    public class Category
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
    }

    //public class SubCategory
    //{
    //    public int Id { get; set; }
    //    public string Slug { get; set; }
    //    public string Name { get; set; }
    //}

    //public class AgeClassification
    //{
    //    public int? From { get; set; }
    //    public int? To { get; set; }
    //}

    //public class Store
    //{
    //    public List<Link> Links { get; set; }
    //    public string CreatedAt { get; set; }
    //    public string UpdatedAt { get; set; }
    //    public string Status { get; set; }
    //    public string ReferenceId { get; set; }
    //    public Price Price { get; set; }
    //}

    //public class Link
    //{
    //    public string Rel { get; set; }
    //    public string Href { get; set; }
    //    public string Title { get; set; }
    //    public string ImageSrc { get; set; }
    //}

    //public class Price
    //{
    //    public decimal Original { get; set; }
    //    public string Currency { get; set; }
    //    public decimal Discount { get; set; }
    //    public decimal Tax { get; set; }
    //}

    //public class Pod
    //{
    //    public List<Link> Links { get; set; }
    //    public string CreatedAt { get; set; }
    //    public string UpdatedAt { get; set; }
    //    public string Status { get; set; }
    //    public string Sku { get; set; }
    //    public bool Salable { get; set; }
    //    public PodPrices Prices { get; set; }
    //}

    public class PodPrices
    {
        public int PriceVersion { get; set; }
        public int DeliverAt { get; set; }
        public string Currency { get; set; }
        public decimal Tax { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal StoreShare { get; set; }
        public int StorePercent { get; set; }
    }
}
