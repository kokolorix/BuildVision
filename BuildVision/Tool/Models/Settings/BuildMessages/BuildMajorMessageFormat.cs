using AlekseyNagovitsyn.BuildVision.Helpers;

namespace AlekseyNagovitsyn.BuildVision.Tool.Models.Settings.BuildMessages
{
    public enum BuildMajorMessageFormat
    {
        [DisplayString(ResourceName = nameof(Resources.EnumBuildStateLabelTemplate_Default))]
        Entire,

        [DisplayString(ResourceName = nameof(Resources.EnumBuildStateLabelTemplate_ShortForm))]
        Unnamed
    }
}