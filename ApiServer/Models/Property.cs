
using NetTopologySuite.Geometries;
//using Newtonsoft.Json;
//using GeoJSON.Net.Converters;
//using Newtonsoft.Json;

namespace WebApi.Models;
public class Property  
    {  
        public int id { get; set; }  
       // public int userId { get; set; }  
        public string address { get; set; } =null!; 
        public int  size { get; set; }  
        public string sizeUnit {get;set;}="yard";
        public long price { get; set; }  
       
        public bool isRentOnly {get;set;}
        public bool isCommercial{get;set;}
        public string name {get;set;}
        public bool isOwner{get;set;}
        //https://www.c-sharpcorner.com/article/restful-api-in-net-core-using-ef-core-and-postgres/
        //[JsonConverter(typeof(GeoJSON.Net.Geometry.Point))]
        //[JsonIgnore] //works for System.Text.Json.Serialization;
        //[Column(TypeName="geometry (Point)")]
        // [Converters(typeof(Point))]
        
        public Point point{get;set;}
        public List<string> imageUrls { get; set; }
    }  