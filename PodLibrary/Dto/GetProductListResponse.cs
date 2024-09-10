using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodLibrary
{
    public class AgeClassification
    {
        public object from { get; set; }
        public object to { get; set; }
    }

    public class Agents
    {
        public List<string> author { get; set; }
    }

    public class Categories
    {
        public MainCategory main_category { get; set; }
        public List<SubCategory> sub_category { get; set; }
        public AgeClassification age_classification { get; set; }
        public string age_group { get; set; }
    }

    public class Comment
    {
        public string user { get; set; }
        public string comment { get; set; }
    }

    public class Data
    {
        [JsonProperty("api_key.is_test")]
        public int api_keyis_test { get; set; }
        public int store_id { get; set; }
        public int api_key_id { get; set; }
        public int api_template_version { get; set; }
        public List<Item> items { get; set; }
        public int page_count { get; set; }
        public int page { get; set; }
        public int page_size { get; set; }
        public int total_count { get; set; }
    }

    public class File
    {
        public string src { get; set; }
        public string title { get; set; }
        public string size { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public string title { get; set; }
        public string variant_title { get; set; }
        public string short_description { get; set; }
        public object title_en { get; set; }
        public object sub_title { get; set; }
        public List<string> publications { get; set; }
        public object language_code { get; set; }
        public string language_title { get; set; }
        public List<object> table_of_contents { get; set; }
        public string type { get; set; }
        public string parent_sku { get; set; }
        public string slug { get; set; }
        public object edition_number { get; set; }
        public int print_number { get; set; }
        public int print_year { get; set; }
        public int print_month { get; set; }
        public string print_city { get; set; }
        public int print_circulation { get; set; }
        public int page_count { get; set; }
        public string book_size { get; set; }
        public string book_size_display_name { get; set; }
        public int width_mm { get; set; }
        public int length_mm { get; set; }
        public object weight_gr { get; set; }
        public string cover_type { get; set; }
        public string binding_type { get; set; }
        public string text_paper_type { get; set; }
        public string text_color { get; set; }
        public object isbn { get; set; }
        public object isbn10 { get; set; }
        public object ddc { get; set; }
        public object volume_count { get; set; }
        public object volume_number { get; set; }
        public string price { get; set; }
        public string summery { get; set; }
        public string format { get; set; }
        public string product_type { get; set; }
        public List<string> tags { get; set; }
        public Agents agents { get; set; }
        public List<string> attachment { get; set; }
        public string print_in { get; set; }
        public List<string> literary_awards { get; set; }
        public Review review { get; set; }
        public List<File> files { get; set; }
        public Categories categories { get; set; }
        public Store store { get; set; }
        public Pod pod { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string title { get; set; }
        public string image_src { get; set; }
    }

    public class MainCategory
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Pod
    {
        public List<Link> links { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string status { get; set; }
        public string sku { get; set; }
        public bool salable { get; set; }
        public Prices prices { get; set; }
    }

    public class Price
    {
        public int original { get; set; }
        public string currency { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
    }

    public class Prices
    {
        public int price_version { get; set; }
        public int deliver_at { get; set; }
        public string currency { get; set; }
        public int tax { get; set; }
        public int original_price { get; set; }
        public int sale_price { get; set; }
        public int store_share { get; set; }
        public int store_percent { get; set; }
    }

    public class Rating
    {
        public int score { get; set; }
        public int count { get; set; }
    }

    public class Review
    {
        public Rating rating { get; set; }
        public List<object> files { get; set; }
        public List<Comment> comments { get; set; }
    }

    public class GetProductListResponse
    {
        public bool success { get; set; }
        public int status { get; set; }
        public List<object> errors { get; set; }
        public string message { get; set; }
        public List<object> validation_errors { get; set; }
        public Data data { get; set; }
    }

    //public class Store
    //{
    //    public List<Link> links { get; set; }
    //    public string created_at { get; set; }
    //    public string updated_at { get; set; }
    //    public string status { get; set; }
    //    public object reference_id { get; set; }
    //    public Price price { get; set; }
    //}

    //public class SubCategory
    //{
    //    public int id { get; set; }
    //    public string slug { get; set; }
    //    public string name { get; set; }
    //}


}
