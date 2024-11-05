using uploadPDFBooK;

public static class MauiProgram
{
    public static Supabase.Client? SupabaseClient { get; private set; } // nullable


    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // إعداد SupabaseClient
        var options = new Supabase.SupabaseOptions
        {
            AutoRefreshToken = true,
           
        };

        SupabaseClient = new Supabase.Client(
            "https://ptkzzvqvazdmjdocgvkt.supabase.co",
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InB0a3p6dnF2YXpkbWpkb2Nndmt0Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzAwNjQ0NzYsImV4cCI6MjA0NTY0MDQ3Nn0.-ly5wevFy3RQz4gkp67wmDvZx99-5lSquNFeECNyxjc",
            options
        );

        return builder.Build();
    }
}
