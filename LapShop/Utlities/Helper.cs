namespace LapShop.Utlities
{
    public class Helper
    {
        public static async Task<string> UploadImage(List<IFormFile> Files, string folderName)
        {
            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImgageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Uploads/" + folderName, ImgageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                        return ImgageName;
                    }
                }
            }
            return string.Empty;
        }
    }
}
