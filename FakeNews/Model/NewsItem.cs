using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls.Primitives;

namespace FakeNews.Model
{
    public class NewsItem
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string HeadLine { get; set; }

        public string SubHead { get; set; }

        public string DateLine { get; set; }

        public string Image { get; set; }

    }
    private static List<NewsItem> getNewsItems()
    {
        var items = new List<NewsItem>();

        items.Add(new NewsItem() {Id = 1,Category = "Financial",
            HeadLine = "Lorem Ipsum",
            SubHead = "doro sit amet",
            DateLine = "Nunc tristique nec",
            Image = "Assets/Financial1.png"});
        items.Add(new NewsItem() {Id = 2,Category = "Financial",
            HeadLine = "Etiam ac felis viverra",
            SubHead = "vulputate nisl ac, aliquet nisi",
            DateLine = "tortor porttitor, eu fermentum ante congue",
            Image = "Assets/Financial2.png"});
        items.Add(new NewsItem() {Id = 3,Category = "Financial",
            HeadLine = "Integer sed turpins erat",
            SubHead = "sed quis hendrerit lorem, quis interdum dolor",
            DateLine = "in viverra metus facilisis sed",
            Image = "Assets/Financial3.png"});
        items.Add(new NewsItem() {Id = 4,Category = "Financial",
            HeadLine = "proin sem neque",
            SubHead = "aliquet quis ipsum tincidunt",
            DateLine = "Integer eleifend",
            Image = "Assets/Financial4.png"});
        items.Add(new NewsItem(){Id = 5,Category = "Financial",
            HeadLine = "Mauris bibendum non leo vitae tempor",
            SubHead = "In nisl tortor, eleifend sed ipsum eget",
            DateLine = "Curabitur dictum augue vitae elementum ultrices",
            Image = "Assets/Financial5.png"});

    }
    public class Newsmanager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems.where(prop => p.Category == category).Tolist();

            NewsItem.Clear();

            filteredNewsItems.ForEach(p => NewsItem.Add(p));
        }
        items.Add(new NewsItem() {Id = 6,Category = "Food",
            HeadLine = "Lorem Ipsum",
            SubHead = "doro sit amet",
            DateLine = "Nunc tristique nec",
            Image = "Assets/Financial6.png"});
        items.Add(new NewsItem()) {Id = 7,Category = "Food",
            HeadLine = "Etiam ac felis viverra",
            SubHead = "vulputate nisl ac, aliquet nisi",
            DateLine = "tortor porttitor, eu fermentum ante congue",
            Image = "Assets/Financial7.png"});
        items.Add(new NewsItem()) {Id = 8,Category = "Financial",
            HeadLine = "Integer sed turpins erat",
            SubHead = "sed quis hendrerit lorem, quis interdum dolor",
            DateLine = "in viverra metus facilisis sed",
            Image = "Assets/Financial8.png"});
        items.Add(new NewsItem()) {Id = 9,Category = "Financial",
             HeadLine = "proin sem neque",
            SubHead = "aliquet quis ipsum tincidunt",
            DateLine = "Integer eleifend",
            Image = "Assets/Financial9.png"});
        items.Add(new NewsItem()) {Id = 10,Category = "Financial",
            HeadLine = "Mauris bibendum non leo vitae tempor",
            SubHead = "In nisl tortor, eleifend sed ipsum eget",
            DateLine = "Curabitur dictum augue vitae elementum ultrices",
            Image = "Assets/Financial10.png"});

        Return items;
    }
}
