using Microsoft.AspNetCore.Components.Forms;

using System.IO;

public static class FileUtils
{
    private const string UploadDirectory = "TempUploads";

    public static async Task<string?> UploadFile(IBrowserFile file, string Id, string webRootPath, string prefix = "")
    {
        if (file == null)
            return null;

        // Generate unique file name
        var uniqueFileName = $"{prefix}{Guid.NewGuid()}_{Id}{Path.GetExtension(file.Name)}";
        var targetPath = Path.Combine(webRootPath, UploadDirectory, uniqueFileName);

        // Ensure the Uploads directory exists
        Directory.CreateDirectory(Path.GetDirectoryName(targetPath));

        // Save the file
        using (var fileStream = File.Create(targetPath))
        {
            await file.OpenReadStream(maxAllowedSize: 10 * 1024 * 1024) // Adjust max size as needed
                       .CopyToAsync(fileStream);
        }

        return targetPath;
    }

    public static void MoveFile(string sourceFilePath, string newFilePath)
    {
        if (File.Exists(sourceFilePath))
        {
            var targetDirectory = Path.GetDirectoryName(newFilePath);
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            File.Move(sourceFilePath, newFilePath, overwrite: true);
        }
    }

    public static void RemoveFile(string? filePath)
    {
        if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }
    public static string GenerateUrl(string filePath, string webRootPath)
    {
        var relativePath = filePath.Replace(webRootPath, "").Replace("\\", "/");
        return $"/{relativePath.TrimStart('/')}";
    }
}
