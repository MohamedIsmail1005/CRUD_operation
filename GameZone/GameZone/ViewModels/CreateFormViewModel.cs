using GameZone.Attributes;
namespace GameZone.ViewModels
{
    public class CreateFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(FileSetting.AllowedExtensions),
            MaxFileSize(FileSetting.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }

}
