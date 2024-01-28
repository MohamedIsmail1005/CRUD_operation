using GameZone.Attributes;

namespace GameZone.ViewModels
{
    public class EditFormViewModel : GameFormViewModel
    {
        public int Id  { get; set; }

        public string? currentCover { get; set; }

        [AllowedExtensions(FileSetting.AllowedExtensions),
    MaxFileSize(FileSetting.MaxFileSizeInBytes)]
        public IFormFile? Cover { get; set; } = default!;
    }
}
