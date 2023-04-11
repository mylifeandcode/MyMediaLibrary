using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Domain
{
    /// <summary>
    /// The location where the media can be found.
    /// </summary>
    /// <example>
    /// Cloud Storage, Media Room DVD Rack, USB Drive
    /// </example>
    public class Location : DescriptiveMediaEntity
    {
        /// <summary>
        /// An optional volume name describing the media location.
        /// </summary>
        /// <example>
        /// USB Drive 5, DVD 20150105, or any other descriptive label.
        /// </example>
        public string? VolumeName { get; set; }
    }
}
