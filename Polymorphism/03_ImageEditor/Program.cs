


using ImageEditor.Models;
namespace ImageEditor;

internal class Program
{
    static void Main(string[] args)
    {

        //Task 3 - Şəkil Redaktoru(Image Editor)
        //Bir şəkil redaktoru proqramında müxtəlif filterlər tətbiq edilir.
        //Filter adlı bir base class yaz, Apply() adlı virtual metod olsun.
        //Ondan miras alan classlar:
        //BlackWhiteFilter
        //VintageFilter
        //BlurFilter
        //Hər biri Apply() metodunu override edib, fərqli mesajlar yazsın, məsələn:
        //“Qara-ağ filter tətbiq edildi.”
        //“Vintage effekti əlavə olundu.”
        //“Şəkil bulanıqlaşdırıldı.”
        //Main() methodunda List<Filter> içərisinə bu filterlərdən əlavə et
        //və foreach ilə Apply() çağır.

        List<Filter> filters = new List<Filter>();
        filters.Add(new BlackWhiteFilter());
        filters.Add(new VintageFilter());
        filters.Add(new BlurFilter());


        foreach (Filter filter in filters)
        {
            filter.Apply();
            Console.WriteLine();
        }

    }
}