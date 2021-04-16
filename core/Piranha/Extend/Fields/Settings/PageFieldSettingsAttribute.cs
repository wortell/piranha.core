using System;

namespace Piranha.Extend.Fields.Settings
{
    /// <summary>
    /// Settings for page fields.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PageFieldSettingsAttribute : FieldSettingsAttribute
    {
        /// <summary>
        /// Gets/sets the currently allowed content type Id.
        /// </summary>
        public string ContentTypeId { get; set; }
    }
}